using System;
using System.Net;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using DMData.Code;
using CBSys.WMSDyn.SQL;
using CBSys.WMSDyn.Model;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using Kingdee.BOS.WebApi.Client;

namespace CBSys.WMSDyn.Unity
{
    /// <summary>
    /// 通用方法
    /// </summary>
    internal static class CommonFunction
    {
        #region Fileds & Constructor
        private static string strSQL;
        private static object obj;

        /// <summary>
        /// 构造函数
        /// </summary>
        static CommonFunction()
        {
            strSQL = string.Empty;
            obj = new object();
        }
        #endregion

        ///// <summary>
        ///// 用户登录验证-取消
        ///// </summary>
        ///// <param name="pUsers"></param>
        ///// <returns></returns>
        //internal static int UserLogin(UserInfo pUsers)
        //{
        //    SqlParameter[] parms = new SqlParameter[]
        //    {
        //        new SqlParameter("@UserName",SqlDbType.VarChar)
        //    };
        //    parms[0].Value = pUsers.UserName;

        //    strSQL = "SELECT UserName,Password,CASE WHEN DATEDIFF(MI,LastLoginDate,GETDATE())>= 5 THEN '0' ELSE LogStatus END LogStatus FROM BD_Users WHERE IsUse = 1 AND UserName = @UserName";

        //    DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

        //    if (dt == null || dt.Rows.Count == 0)//没有数据-用户不存在或已经被禁用
        //        return 0;
        //    else if (dt.Rows[0]["Password"] == null || pUsers.Password != DataEncoder.DecryptData(dt.Rows[0]["Password"].ToString()))//密码不正确                
        //        return 1;
        //    else if (bool.Parse(dt.Rows[0]["LogStatus"].ToString()))//用户已经登录
        //        return 2;
        //    else
        //        return -1;//验证成功
        //}

        /// <summary>
        /// 更新用户登录状态
        /// </summary>
        /// <param name="pUser"></param>
        /// <param name="pLogin"></param>
        internal static void UpdateLoginStatus(UserInfo pUser, bool pLogin)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@UserName",SqlDbType.VarChar),
                new SqlParameter("@LogStatus",SqlDbType.Bit)
            };
            parms[0].Value = pUser == null ? "" : pUser.UserName;
            parms[1].Value = pLogin ? 1 : 0;

            strSQL = "UPDATE BD_Users SET LogStatus = @LogStatus,LastLoginDate = GETDATE() WHERE UserName = @UserName";

            SQLHelper.ExecuteNonQuery(strSQL, parms);
        }

        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        internal static UserInfo GetUserInfoByName(string pName)
        {
            UserInfo entry = new UserInfo();
            K3CloudApiClient client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);
            string strJson = "{\"FormId\":\"BD_Empinfo\",\"FieldKeys\":\"FNAME,FNumber,FPERSONID,FSTAFFID,FPOSTDEPT\",\"FilterString\":\"FNAME = '" + UserSetting.K3CloudInf.C_USERNAME + "'\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
            if (bLogin)
            {
                try
                {
                    List<List<object>> list = client.ExecuteBillQuery(strJson);
                    if (list.Count > 0)
                    {
                        entry.UserName = UserSetting.K3CloudInf.C_USERNAME;
                        entry.FNumber = list[0][1].ToString();
                        entry.PersonId = list[0][2] == null ? 0 : int.Parse(list[0][2].ToString());
                        entry.StaffId = list[0][3] == null ? 0 : int.Parse(list[0][3].ToString());
                        entry.FDeptId = list[0][4] == null ? 0 : int.Parse(list[0][4].ToString());
                    }
                    else
                        return null;
                }
                catch //(Exception ex)
                {
                    return null;
                }
            }
            return entry;

            //UserInfo entity;
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@UserName",SqlDbType.VarChar)
            //};
            //parms[0].Value = pName;

            //strSQL = "SELECT PID,UserId,UserName,Password,FDeptId,LogStatus,Creator,CreationDate,Modifier,ModificationDate,LastLoginDate,Flag,Description FROM BD_Users WHERE IsUse = 1 AND UserName = @UserName";

            //DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

            //if (dt == null || dt.Rows.Count == 0)
            //    return null;
            //else
            //{
            //    entity = new UserInfo();

            //    entity.PID = int.Parse(dt.Rows[0]["PID"].ToString());
            //    entity.UserId = dt.Rows[0]["UserId"] == null ? 0 : int.Parse(dt.Rows[0]["UserId"].ToString());
            //    entity.UserName = pName;
            //    entity.Password = dt.Rows[0]["Password"] == null ? "" : dt.Rows[0]["Password"].ToString();
            //    entity.FDeptId = dt.Rows[0]["FDeptId"] == null ? 0 : int.Parse(dt.Rows[0]["FDeptId"].ToString());
            //    entity.LogStatus = dt.Rows[0]["LogStatus"] == null ? false : bool.Parse(dt.Rows[0]["LogStatus"].ToString());
            //    entity.IsUse = true;
            //    entity.Creator = dt.Rows[0]["Creator"] == null ? "" : dt.Rows[0]["Creator"].ToString();
            //    entity.CreationDate = dt.Rows[0]["CreationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["CreationDate"].ToString());
            //    entity.Modifier = dt.Rows[0]["Modifier"] == null ? "" : dt.Rows[0]["Modifier"].ToString();
            //    entity.ModificationDate = dt.Rows[0]["ModificationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["ModificationDate"].ToString());
            //    entity.LastLoginDate = dt.Rows[0]["LastLoginDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["LastLoginDate"].ToString());
            //    entity.Flag = dt.Rows[0]["Flag"] == null ? byte.Parse("0") : byte.Parse(dt.Rows[0]["Flag"].ToString());
            //    entity.Description = dt.Rows[0]["Description"] == null ? "" : dt.Rows[0]["Description"].ToString();

            //    return entity;
            //}
        }

        /// <summary>
        /// 根据ID获取K3部门信息
        /// </summary>
        /// <param name="pDeptId"></param>
        /// <returns></returns>
        internal static DepartmentInfo GetDeptmentInfoById(int? pDeptId)
        {
            if (pDeptId == null) return null;
            K3CloudApiClient client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            DepartmentInfo entry = new DepartmentInfo();
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);
            string strJson = "{\"FormId\":\"BD_Department\",\"FieldKeys\":\"FDeptId,FNAME,FNUMBER\",\"FilterString\":\"FDeptId = " + pDeptId.ToString() + "\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
            if (bLogin)
            {
                try
                {
                    List<List<object>> list = client.ExecuteBillQuery(strJson);
                    if (list.Count > 0)
                    {
                        entry.FDeptId = pDeptId;
                        entry.FName = list[0][1].ToString();
                        entry.FNumber = list[0][2].ToString();
                    }
                    else
                        return null;
                }
                catch
                {
                    return null;
                }
            }
            return entry;
        }

        /// <summary>
        /// 根据条码获取任务单信息
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        internal static MoInfo GetMoInfoByBarcode(string pBarcode)
        {
            MoInfo entity;
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@Barcode",SqlDbType.VarChar)
            };
            parms[0].Value = pBarcode;

            strSQL = "SELECT PID,Barcode,FID,FBillNo,FDate,FEntryId,FNumber,FQTY,FSEQ,GroupId,Times,Creator,CreationDate,Modifier,ModificationDate,Flag,Description  FROM PRD_Mo WHERE Barcode = @Barcode";

            DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

            if (dt == null || dt.Rows.Count == 0)
                return null;
            else
            {
                entity = new MoInfo();

                entity.PID = int.Parse(dt.Rows[0]["PID"].ToString());
                entity.Barcode = pBarcode;
                entity.FID = dt.Rows[0]["FID"] == null ? 0 : int.Parse(dt.Rows[0]["FID"].ToString());
                entity.FBillNo = dt.Rows[0]["FBillNo"] == null ? "" : dt.Rows[0]["FBillNo"].ToString();
                entity.FDate = dt.Rows[0]["FDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["FDate"].ToString());
                entity.FEntryId = dt.Rows[0]["FEntryId"] == null ? 0 : int.Parse(dt.Rows[0]["FEntryId"].ToString());
                entity.FNumber = dt.Rows[0]["FNumber"] == null ? "" : dt.Rows[0]["FNumber"].ToString();
                entity.FQTY = dt.Rows[0]["FQTY"] == null ? 0 : decimal.Parse(dt.Rows[0]["FQTY"].ToString());
                entity.FSEQ = dt.Rows[0]["FSEQ"] == null ? 0 : int.Parse(dt.Rows[0]["FSEQ"].ToString());
                entity.FDeptId = dt.Rows[0]["GroupId"] == null ? 0 : int.Parse(dt.Rows[0]["GroupId"].ToString());
                entity.Times = dt.Rows[0]["Times"] == null ? 0 : int.Parse(dt.Rows[0]["Times"].ToString());

                entity.Creator = dt.Rows[0]["Creator"] == null ? "" : dt.Rows[0]["Creator"].ToString();
                entity.CreationDate = dt.Rows[0]["CreationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["CreationDate"].ToString());
                entity.Modifier = dt.Rows[0]["Modifier"] == null ? "" : dt.Rows[0]["Modifier"].ToString();
                entity.ModificationDate = dt.Rows[0]["ModificationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["ModificationDate"].ToString());
                entity.Flag = dt.Rows[0]["Flag"] == null ? byte.Parse("0") : byte.Parse(dt.Rows[0]["Flag"].ToString());
                entity.Description = dt.Rows[0]["Description"] == null ? "" : dt.Rows[0]["Description"].ToString();

                return entity;
            }
        }

        /// <summary>
        /// 根据生产车间ID获取当天该车间的生产订单物料编码
        /// </summary>
        /// <param name="pDepartId"></param>
        /// <returns></returns>
        internal static List<string> GetFNumbersByDepartId(int pDeptId)
        {
            List<string> lstReturn = new List<string>();
            K3CloudApiClient client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            DepartmentInfo entry = new DepartmentInfo();
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);

            string strJson;
            if (pDeptId == 0)
                strJson = "{\"FormId\":\"PRD_MO\",\"FieldKeys\":\"FBillNo,FMaterialID.FNumber\",\"FilterString\":\"TO_CHAR(FDate,'yyyy-mm-dd') = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
            else
                strJson = "{\"FormId\":\"PRD_MO\",\"FieldKeys\":\"FBillNo,FMaterialID.FNumber\",\"FilterString\":\"TO_CHAR(FDate,'yyyy-mm-dd') = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND FWorkShopID = " + pDeptId + "\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
            if (bLogin)
            {
                try
                {
                    List<List<object>> list = client.ExecuteBillQuery(strJson);
                    for (int i = 0; i < list.Count; i++)
                    {
                        lstReturn.Add(list[i][1].ToString());
                    }
                }
                catch
                {
                    return new List<string>();
                }
            }

            return lstReturn;
        }

        /// <summary>
        /// 根据物料编码list获取物料信息list
        /// </summary>
        /// <param name="pFNumbers"></param>
        /// <returns></returns>
        internal static IList GetMTLListByFNumbers(List<string> pFNumbers)
        {
            IList ilist;
            MaterialInfo entry;
            K3CloudApiClient client;
            string FNumbers = string.Empty, strJson;

            for (int i = 0; i < pFNumbers.Count; i++)
            {
                if (i > 0)
                    FNumbers += ",";
                FNumbers += "'" + pFNumbers[i] + "'";
            }

            strJson = "{\"FormId\":\"BD_MATERIAL\",\"FieldKeys\":\"FMaterialId,FNumber,FName,F_PAEZ_BRAND.FDataValue,F_PAEZ_SERIES.FDataValue,F_PAEZ_TRADE.FDataValue,F_PAEZ_CARSERIES.FDataValue,F_PAEZ_CARTYPE.FDataValue,F_PAEZ_COLOR.FDataValue\",\"FilterString\":\"FUseOrgId = 100508 AND FNumber IN(" + FNumbers + ")\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";

            ilist = new ArrayList();
            client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);
            if (bLogin)
            {
                try
                {
                    List<List<object>> list = client.ExecuteBillQuery(strJson);
                    for (int i = 0; i < list.Count; i++)
                    {
                        entry = new MaterialInfo();

                        entry.FMaterialId = int.Parse(list[i][0].ToString());
                        entry.FNumber = list[i][1].ToString();
                        entry.FName = list[i][2].ToString();

                        entry.F_PAEZ_BRAND = list[i][3].ToString();
                        entry.F_PAEZ_SERIES = list[i][4].ToString();
                        entry.F_PAEZ_TRADE = list[i][5].ToString();
                        entry.F_PAEZ_CARSERIES = list[i][6].ToString();
                        entry.F_PAEZ_CARTYPE = list[i][7].ToString();

                        entry.F_PAEZ_COLOR = list[i][8].ToString();

                        ilist.Add(entry);
                    }
                }
                catch
                {
                    return new ArrayList();
                }
            }

            return ilist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static DataTable GetDrawing()
        {
            //string strSQL = @"SELECT DISTINCT NVL(ASSDL.FDATAVALUE,' ') F_PAEZ_TRADE,NVL(ASSDL2.FDATAVALUE,' ') F_PAEZ_CARSERIES,NVL(ASSDL3.FDATAVALUE,' ') F_PAEZ_CARTYPE
            //FROM T_PRD_MO MO
            //INNER JOIN T_PRD_MOENTRY MOE ON MO.FID = MOE.FID
            //INNER JOIN T_PRD_MOENTRY_A MOA ON MOE.FENTRYID = MOA.FENTRYID AND MOA.FSTATUS IN(3,4)
            //LEFT JOIN T_BD_MATERIAL MTL ON MOE.FMATERIALID = MTL.FMATERIALID
            //LEFT JOIN T_BAS_ASSISTANTDATAENTRY_L ASSDL ON MTL.F_PAEZ_TRADE = ASSDL.FENTRYID AND ASSDL.FLOCALEID = 2052
            //LEFT JOIN T_BAS_ASSISTANTDATAENTRY_L ASSDL2 ON MTL.F_PAEZ_CARSERIES = ASSDL2.FENTRYID AND ASSDL2.FLOCALEID = 2052
            //LEFT JOIN T_BAS_ASSISTANTDATAENTRY_L ASSDL3 ON MTL.F_PAEZ_CARTYPE = ASSDL3.FENTRYID AND ASSDL3.FLOCALEID = 2052
            //WHERE TO_CHAR(MO.FDATE,'yyyy-mm-dd') = '2019-03-14' AND MOE.FWORKSHOPID = 100688";


            string strSQL = string.Empty;
            DataTable dtMTL = new DataTable();
            DataRow dr;
            dtMTL.Columns.Add("F_PAEZ_Trade");
            dtMTL.Columns.Add("F_PAEZ_Carseries");
            dtMTL.Columns.Add("F_PAEZ_Cartype");

            UserSetting.UserInf.FDeptId = 100688;//test

            if (UserSetting.UserInf == null || UserSetting.UserInf.FDeptId == 0) return null;
            K3CloudApiClient client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            DepartmentInfo entry = new DepartmentInfo();
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);
            string strJson = "{\"FormId\":\"PRD_MO\",\"FieldKeys\":\"F_PAEZ_Trade,F_PAEZ_Carseries,F_PAEZ_Cartype\",\"FilterString\":\"TO_CHAR(FDATE,'yyyy-mm-dd')='" + DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + "' AND FWorkShopID=" + UserSetting.UserInf.FDeptId + " \",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
            if (bLogin)
            {
                try
                {
                    List<List<object>> list = client.ExecuteBillQuery(strJson);
                    if (list.Count > 0)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            dr = dtMTL.NewRow();
                            dr["F_PAEZ_Trade"] = list[i][0] == null ? "" : list[i][0].ToString();
                            dr["F_PAEZ_Carseries"] = list[i][1] == null ? "" : list[i][1].ToString();
                            dr["F_PAEZ_Cartype"] = list[i][2] == null ? "" : list[i][2].ToString();

                            dtMTL.Rows.Add(dr);
                        }
                    }
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            DataView dv = dtMTL.DefaultView;
            dtMTL = dv.ToTable(true, new string[] { "F_PAEZ_Trade", "F_PAEZ_Carseries", "F_PAEZ_Cartype" });

            strSQL = "SELECT DR.[FileName] 图纸,RL.SourcePath 源路径,DR.Creator 创建人,DR.[Description] 描述,RL.CategoryId 类型 FROM RL_MTLDrawing RL INNER JOIN BD_Drawing DR ON RL.SourcePath = DR.SourcePath WHERE";
            for (int i = 0; i < dtMTL.Rows.Count; i++)
            {
                if (i > 0) strSQL += " OR ";
                strSQL += " (RL.F_PAEZ_TRADE='" + dtMTL.Rows[i]["F_PAEZ_Trade"].ToString() + "' AND RL.F_PAEZ_CARSERIES='" + dtMTL.Rows[i]["F_PAEZ_Carseries"].ToString() + "' AND RL.F_PAEZ_CARTYPE='" + dtMTL.Rows[i]["F_PAEZ_Cartype"].ToString() + "')";
            }

            return SQLHelper.ExecuteTable(strSQL);
        }

        /// <summary>
        /// 根据用户名和条码查询图纸路径
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        internal static string GetUserDrawing(string pName, string pBarcode)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Barcode", SqlDbType.VarChar)
            };
            parms[0].Value = pName;
            parms[1].Value = pBarcode;

            strSQL = @"SELECT A.UserName,B.Barcode,B.FBillNo,C.FPath,C.FName,C.Suffix
            FROM BD_Users A
            INNER JOIN PRD_Mo B ON A.GroupId = B.GroupId
            INNER JOIN BD_Drawing C ON B.FNumber = C.FNumber
            WHERE A.UserName = @UserName AND B.Barcode = @Barcode";

            DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

            if (dt == null || dt.Rows.Count == 0)
                return "失败：找不到相应的图纸文件或不在开料任务中";
            else
                return dt.Rows[0]["FPath"].ToString() + "\\" + dt.Rows[0]["FName"].ToString();
        }

        /// <summary>
        /// 根据用户名获取用户的所有条码
        /// </summary>
        /// <param name="pName">用户名</param>
        /// <returns></returns>
        internal static DataTable GetUserDrawing(string pName)
        {
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@UserName", SqlDbType.VarChar)
            //};
            //parms[0].Value = pName;

            //strSQL = @"SELECT A.UserName,B.Barcode,B.FBillNo,C.FPath,C.FName,C.Suffix
            //FROM BD_Users A
            //INNER JOIN PRD_Mo B ON A.GroupId = B.GroupId
            //INNER JOIN BD_Drawing C ON B.FNumber = C.FNumber
            //WHERE A.UserName = @UserName";

            //return SQLHelper.ExecuteTable(strSQL, parms);

            strSQL = "SELECT TOP 50 FileName 图纸,SourcePath 源路径,Creator 创建人,Description 描述 FROM BD_Drawing  ORDER BY PID DESC";
            return SQLHelper.ExecuteTable(strSQL);
        }

        /// <summary>
        /// 根据物料编码获取图纸信息
        /// </summary>
        /// <param name="pFNumber"></param>
        /// <returns></returns>
        internal static DrawingInfo GetDrawingInfoByFNumber(string pFNumber)
        {
            DrawingInfo entity;
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@FNumber",SqlDbType.VarChar)
            };
            parms[0].Value = pFNumber;

            strSQL = "SELECT PID,FMaterialId,FNumber,SourcePath,FileName,FileSuffix,FileSize,Creator,CreationDate,Flag,IsDelete,Description  FROM BD_Drawing WHERE FNumber = @FNumber";

            DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

            if (dt == null || dt.Rows.Count == 0)
                return null;
            else
            {
                entity = new DrawingInfo();

                entity.PID = int.Parse(dt.Rows[0]["PID"].ToString());
                entity.FMaterialId = dt.Rows[0]["FMaterialId"] == null ? 0 : int.Parse(dt.Rows[0]["FMaterialId"].ToString());
                entity.FNumber = pFNumber;
                entity.SourcePath = dt.Rows[0]["SourcePath"] == null ? "" : dt.Rows[0]["SourcePath"].ToString();
                entity.FileName = dt.Rows[0]["FileName"] == null ? "" : dt.Rows[0]["FileName"].ToString();
                entity.FileSuffix = dt.Rows[0]["FileSuffix"] == null ? "" : dt.Rows[0]["FileSuffix"].ToString();
                entity.FileSize = dt.Rows[0]["FileSize"] == null ? 0 : int.Parse(dt.Rows[0]["FileSize"].ToString());

                entity.Creator = dt.Rows[0]["Creator"] == null ? "" : dt.Rows[0]["Creator"].ToString();
                entity.CreationDate = dt.Rows[0]["CreationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["CreationDate"].ToString());
                entity.Flag = dt.Rows[0]["Flag"] == null ? false : bool.Parse(dt.Rows[0]["Flag"].ToString());
                entity.IsDelete = dt.Rows[0]["IsDelete"] == null ? false : bool.Parse(dt.Rows[0]["IsDelete"].ToString());
                entity.Description = dt.Rows[0]["Description"] == null ? "" : dt.Rows[0]["Description"].ToString();

                return entity;
            }
        }

        /// <summary>
        /// 根据文件名获取Drawing Context
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        internal static DrawingInfo DownLoadDrawing(string pBarcode)//应改成return table
        {
            DataTable dt;
            DrawingInfo entry = new DrawingInfo();

            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@SourcePath",SqlDbType.VarChar)
            };
            parms[0].Value = pBarcode;

            strSQL = "SELECT PID,FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,CreationDate,Flag,IsDelete,Description,Context FROM BD_Drawing WHERE SourcePath = @SourcePath";

            dt = SQLHelper.ExecuteTable(strSQL, parms);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            try
            {
                entry.PID = int.Parse(dt.Rows[0]["PID"].ToString());
                entry.FMaterialId = int.Parse(dt.Rows[0]["FMaterialId"].ToString());
                entry.FNumber = dt.Rows[0]["FNumber"].ToString();
                entry.FileName = dt.Rows[0]["FileName"].ToString();
                entry.FileSuffix = dt.Rows[0]["FileSuffix"].ToString();

                entry.FileSize = long.Parse(dt.Rows[0]["FileSize"].ToString());
                entry.SourcePath = dt.Rows[0]["SourcePath"].ToString();
                entry.Creator = dt.Rows[0]["Creator"].ToString();
                entry.CreationDate = DateTime.Parse(dt.Rows[0]["CreationDate"].ToString());
                entry.Flag = bool.Parse(dt.Rows[0]["Flag"].ToString());

                entry.IsDelete = bool.Parse(dt.Rows[0]["IsDelete"].ToString());
                entry.Description = dt.Rows[0]["Description"].ToString();
                entry.Context = (byte[])dt.Rows[0]["Context"];
            }
            catch //(Exception ex)
            {
                return null;
            }

            return entry;
        }

        /// <summary>
        /// 上传图纸
        /// </summary>
        /// <param name="pDrawingInf"></param>
        internal static void UpLoadDrawing(DrawingInfo pDrawingInf)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@FMaterialId",SqlDbType.Int),
                new SqlParameter("@FNumber", SqlDbType.VarChar),
                new SqlParameter("@FileName",SqlDbType.VarChar),
                new SqlParameter("@FileSuffix",SqlDbType.VarChar),
                new SqlParameter("@FileSize",SqlDbType.BigInt),

                new SqlParameter("@SourcePath",SqlDbType.VarChar),
                new SqlParameter("@Creator",SqlDbType.VarChar),
                new SqlParameter("@Description",SqlDbType.VarChar),
                new SqlParameter("@Context",SqlDbType.Binary,pDrawingInf.Context.Length)
            };
            parms[0].Value = pDrawingInf.FMaterialId;
            parms[1].Value = pDrawingInf.FNumber;
            parms[2].Value = pDrawingInf.FileName;
            parms[3].Value = pDrawingInf.FileSuffix;
            parms[4].Value = pDrawingInf.FileSize;

            parms[5].Value = pDrawingInf.SourcePath;
            parms[6].Value = pDrawingInf.Creator;
            parms[7].Value = pDrawingInf.Description;
            parms[8].Value = pDrawingInf.Context;

            strSQL = @"INSERT INTO BD_Drawing(FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,Description,Context)
            VALUES(@FMaterialId,@FNumber,@FileName,@FileSuffix,@FileSize,@SourcePath,@Creator,@Description,@Context)";

            SQLHelper.ExecuteNonQuery(strSQL, parms);
        }

        /// <summary>
        /// 更新图纸
        /// </summary>
        /// <param name="pDrawingInf"></param>
        internal static void UpdateDrawing(DrawingInfo pDrawingInf)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@FMaterialId",SqlDbType.Int),
                new SqlParameter("@FNumber", SqlDbType.VarChar),
                new SqlParameter("@FileName",SqlDbType.VarChar),
                new SqlParameter("@FileSuffix",SqlDbType.VarChar),
                new SqlParameter("@FileSize",SqlDbType.BigInt),

                new SqlParameter("@SourcePath",SqlDbType.VarChar),
                new SqlParameter("@Creator",SqlDbType.VarChar),
                new SqlParameter("@Description",SqlDbType.VarChar),
                new SqlParameter("@Context",SqlDbType.Binary,pDrawingInf.Context.Length)
            };
            parms[0].Value = pDrawingInf.FMaterialId;
            parms[1].Value = pDrawingInf.FNumber;
            parms[2].Value = pDrawingInf.FileName;
            parms[3].Value = pDrawingInf.FileSuffix;
            parms[4].Value = pDrawingInf.FileSize;

            parms[5].Value = pDrawingInf.SourcePath;
            parms[6].Value = pDrawingInf.Creator;
            parms[7].Value = pDrawingInf.Description;
            parms[8].Value = pDrawingInf.Context;

            strSQL = @"UPDATE BD_Drawing SET IsDelete = 1 WHERE SourcePath = @SourcePath;
            INSERT INTO BD_Drawing(FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,Description,Context)
            VALUES(@FMaterialId,@FNumber,@FileName,@FileSuffix,@FileSize,@SourcePath,@Creator,@Description,@Context);
            ";

            SQLHelper.ExecuteNonQuery(strSQL, parms);
        }

        /// <summary>
        /// Meger Drawing
        /// </summary>
        /// <param name="pDrawingInf"></param>
        internal static void MergeDrawing(DrawingInfo pDrawingInf)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@FMaterialId",SqlDbType.Int),
                new SqlParameter("@FNumber", SqlDbType.VarChar),
                new SqlParameter("@FileName",SqlDbType.VarChar),
                new SqlParameter("@FileSuffix",SqlDbType.VarChar),
                new SqlParameter("@FileSize",SqlDbType.BigInt),

                new SqlParameter("@SourcePath",SqlDbType.VarChar),
                new SqlParameter("@Creator",SqlDbType.VarChar),
                new SqlParameter("@Description",SqlDbType.VarChar),
                new SqlParameter("@Context",SqlDbType.Binary,pDrawingInf.Context.Length)
            };
            parms[0].Value = pDrawingInf.FMaterialId;
            parms[1].Value = pDrawingInf.FNumber;
            parms[2].Value = pDrawingInf.FileName;
            parms[3].Value = pDrawingInf.FileSuffix;
            parms[4].Value = pDrawingInf.FileSize;

            parms[5].Value = pDrawingInf.SourcePath;
            parms[6].Value = pDrawingInf.Creator;
            parms[7].Value = pDrawingInf.Description;
            parms[8].Value = pDrawingInf.Context;

            strSQL = @"MERGE INTO BD_Drawing AS T
            USING 
            (
	            SELECT @FMaterialId FMaterialId,@FNumber FNumber,@FileName FileName,@FileSuffix FileSuffix,@FileSize FileSize,@SourcePath SourcePath,@Creator Creator,@Description Description,@Context Context
            ) AS O ON T.SourcePath = O.SourcePath
            WHEN MATCHED
                THEN UPDATE SET
		            FMaterialId = O.FMaterialId,FNumber = O.FNumber, FileName = O.FileName,FileSuffix = O.FileSuffix,FileSize = O.FileSize,Creator = O.Creator, Description = O.Description,Context = O.Context
            WHEN NOT MATCHED
                THEN INSERT(FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,Description,Context)
	            VALUES(O.FMaterialId, O.FNumber, O.FileName, O.FileSuffix, O.FileSize,O.SourcePath, O.Creator, O.Description, O.Context);";

            SQLHelper.ExecuteNonQuery(strSQL, parms);
        }

        /// <summary>
        /// Merge MTLDrawing
        /// </summary>
        /// <param name="pMTLDrawingInf"></param>
        internal static void MergeMTLDrawing(MTLDrawingInfo pMTLDrawingInf)
        {
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@CategoryId",SqlDbType.Int),
            //    new SqlParameter("@SourcePath", SqlDbType.VarChar),
            //    new SqlParameter("@Barcode",SqlDbType.VarChar),
            //    new SqlParameter("@FMaterialId",SqlDbType.Int),
            //    new SqlParameter("@FNumber",SqlDbType.VarChar),

            //    new SqlParameter("@F_PAEZ_TRADE",SqlDbType.VarChar),
            //    new SqlParameter("@F_PAEZ_CARSERIES",SqlDbType.VarChar),
            //    new SqlParameter("@F_PAEZ_CARTYPE",SqlDbType.VarChar),
            //    new SqlParameter("@Flag",SqlDbType.Bit),
            //    new SqlParameter("@Description",SqlDbType.VarChar)
            //};
            //parms[0].Value = pMTLDrawingInf.CategoryId;
            //parms[1].Value = pMTLDrawingInf.SourcePath;
            //parms[2].Value = pMTLDrawingInf.Barcode == null ? "" : pMTLDrawingInf.Barcode;
            //parms[3].Value = pMTLDrawingInf.FMaterialId;
            //parms[4].Value = pMTLDrawingInf.FNumber == null ? "" : pMTLDrawingInf.FNumber;

            //parms[5].Value = pMTLDrawingInf.F_PAEZ_TRADE == null ? "" : pMTLDrawingInf.F_PAEZ_TRADE;
            //parms[6].Value = pMTLDrawingInf.F_PAEZ_CARSERIES == null ? "" : pMTLDrawingInf.F_PAEZ_CARSERIES;
            //parms[7].Value = pMTLDrawingInf.F_PAEZ_CARTYPE == null ? "" : pMTLDrawingInf.F_PAEZ_CARTYPE;
            //parms[8].Value = pMTLDrawingInf.Flag;
            //parms[9].Value = pMTLDrawingInf.Description == null ? "" : pMTLDrawingInf.Description;

            //strSQL = @"MERGE INTO RL_MTLDrawing AS T
            //USING
            //(
            // SELECT @CategoryId CategoryId,@SourcePath SourcePath,@Barcode Barcode,@FMaterialId FMaterialId,@FNumber FNumber,@F_PAEZ_TRADE F_PAEZ_TRADE,@F_PAEZ_CARSERIES F_PAEZ_CARSERIES,@F_PAEZ_CARTYPE F_PAEZ_CARTYPE,@Flag Flag,@Description Description
            //) AS O ON T.SourcePath = O.SourcePath
            //WHEN MATCHED
            //    THEN UPDATE SET
            //  CategoryId = O.CategoryId,Barcode = O.Barcode, FMaterialId = O.FMaterialId,FNumber = O.FNumber,F_PAEZ_TRADE = O.F_PAEZ_TRADE,F_PAEZ_CARSERIES = O.F_PAEZ_CARSERIES, F_PAEZ_CARTYPE = O.F_PAEZ_CARTYPE,Flag = O.Flag,Description = O.Description
            //WHEN NOT MATCHED
            //    THEN INSERT(CategoryId,SourcePath,Barcode,FMaterialId,FNumber,F_PAEZ_TRADE,F_PAEZ_CARSERIES,F_PAEZ_CARTYPE,Flag,Description)
            // VALUES(O.CategoryId, O.SourcePath, O.Barcode, O.FMaterialId, O.FNumber,O.F_PAEZ_TRADE, O.F_PAEZ_CARSERIES, O.F_PAEZ_CARTYPE, O.Flag,O.Description);";

            //SQLHelper.ExecuteNonQuery(strSQL, parms);

            pMTLDrawingInf.Barcode = pMTLDrawingInf.Barcode == null ? "" : pMTLDrawingInf.Barcode;
            pMTLDrawingInf.FNumber = pMTLDrawingInf.FNumber == null ? "" : pMTLDrawingInf.FNumber;
            pMTLDrawingInf.F_PAEZ_TRADE = pMTLDrawingInf.F_PAEZ_TRADE == null ? "" : pMTLDrawingInf.F_PAEZ_TRADE;
            pMTLDrawingInf.F_PAEZ_CARSERIES = pMTLDrawingInf.F_PAEZ_CARSERIES == null ? "" : pMTLDrawingInf.F_PAEZ_CARSERIES;
            pMTLDrawingInf.F_PAEZ_CARTYPE = pMTLDrawingInf.F_PAEZ_CARTYPE == null ? "" : pMTLDrawingInf.F_PAEZ_CARTYPE;
            pMTLDrawingInf.Description = pMTLDrawingInf.Description == null ? "" : pMTLDrawingInf.Description;

            strSQL = @"MERGE INTO RL_MTLDrawing AS T
            USING
            (
             SELECT " + pMTLDrawingInf.CategoryId + " CategoryId,'" + pMTLDrawingInf.SourcePath + "' SourcePath,'" + pMTLDrawingInf.Barcode + "' Barcode," + pMTLDrawingInf.FMaterialId + " FMaterialId,'" + pMTLDrawingInf.FNumber + "' FNumber,'" + pMTLDrawingInf.F_PAEZ_TRADE + "' F_PAEZ_TRADE,'" + pMTLDrawingInf.F_PAEZ_CARSERIES + "' F_PAEZ_CARSERIES,'" + pMTLDrawingInf.F_PAEZ_CARTYPE + "' F_PAEZ_CARTYPE,1 Flag,'" + pMTLDrawingInf.Description + @"' Description
            ) AS O ON T.SourcePath = O.SourcePath
            WHEN MATCHED
                THEN UPDATE SET
              CategoryId = O.CategoryId,Barcode = O.Barcode, FMaterialId = O.FMaterialId,FNumber = O.FNumber,F_PAEZ_TRADE = O.F_PAEZ_TRADE,F_PAEZ_CARSERIES = O.F_PAEZ_CARSERIES, F_PAEZ_CARTYPE = O.F_PAEZ_CARTYPE,Flag = O.Flag,Description = O.Description
            WHEN NOT MATCHED
                THEN INSERT(CategoryId,SourcePath,Barcode,FMaterialId,FNumber,F_PAEZ_TRADE,F_PAEZ_CARSERIES,F_PAEZ_CARTYPE,Flag,Description)
             VALUES(O.CategoryId, O.SourcePath, O.Barcode, O.FMaterialId, O.FNumber,O.F_PAEZ_TRADE, O.F_PAEZ_CARSERIES, O.F_PAEZ_CARTYPE, O.Flag,O.Description);";

            SQLHelper.ExecuteNonQuery(strSQL);
        }

        /// <summary>
        /// 检查Drawing文件名是否存在
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <returns></returns>
        internal static bool Check_DrawingFileName(string pSourcePath)
        {
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@SourcePath",SqlDbType.VarChar)
            //};
            //parms[0].Value = pSourcePath;

            strSQL = "SELECT COUNT(*) FROM BD_Drawing WHERE IsDelete = 0 AND SourcePath = '" + pSourcePath + "'";
            //obj = SQLHelper.ExecuteScalar(strSQL, parms);
            obj = SQLHelper.ExecuteScalar(strSQL);

            if ((int)obj > 0)
                return true;
            return false;
        }

        /// <summary>
        /// 删除图纸
        /// </summary>
        /// <param name="pSourcePath"></param>
        internal static void DeleteDrawing(string pSourcePath)
        {
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@SourcePath",SqlDbType.VarChar)
            //};
            //parms[0].Value = pSourcePath;

            //strSQL = "UPDATE BD_Drawing SET IsDelete = 1 WHERE SourcePath = @SourcePath";

            //SQLHelper.ExecuteNonQuery(strSQL, parms);

            SQLHelper.ExecuteNonQuery("UPDATE BD_Drawing SET IsDelete = 1 WHERE SourcePath = '" + pSourcePath + "'");
        }

        /// <summary>
        /// 修改图纸锁定状态
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <param name="pStatus"></param>
        internal static void LockDrawing(string pSourcePath, bool pStatus)
        {
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@SourcePath",SqlDbType.VarChar),
            //    new SqlParameter("@Flag",SqlDbType.Bit)
            //};
            //parms[0].Value = pSourcePath;
            //parms[1].Value = pStatus;

            //strSQL = "UPDATE BD_Drawing SET Flag = @Flag WHERE SourcePath = @SourcePath";

            //SQLHelper.ExecuteNonQuery(strSQL, parms);

            int iFlag = pStatus ? 1 : 0;

            SQLHelper.ExecuteNonQuery("UPDATE BD_Drawing SET Flag = " + iFlag + " WHERE SourcePath = '" + pSourcePath + "'");
        }

        /// <summary>
        /// 根据物料编码获取物料信息
        /// </summary>
        /// <param name="pFNumber"></param>
        /// <returns></returns>
        internal static MaterialInfo GetMaterialInfoByFNumber(string pFNumber)
        {
            //MaterialInfo entity;
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //    new SqlParameter("@FNumber",SqlDbType.VarChar)
            //};
            //parms[0].Value = pFNumber;

            //strSQL = "SELECT PID,FMaterialId,FNumber,FName,FUseOrgId,FGroupId,FDocumentStatus,FForbidStatus,F_PAEZ_BRAND,F_PAEZ_SERIES,F_PAEZ_TRADE,F_PAEZ_CARSERIES,F_PAEZ_CARTYPE,F_PAEZ_COLOR,Creator,CreationDate,Modifier,ModificationDate,Description FROM BD_Material WHERE FNumber = @FNumber";

            //DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

            //if (dt == null || dt.Rows.Count == 0)
            //    return null;
            //else
            //{
            //    entity = new MaterialInfo();

            //    entity.PID = int.Parse(dt.Rows[0]["PID"].ToString());
            //    entity.FMaterialId = dt.Rows[0]["FMaterialId"] == null ? 0 : int.Parse(dt.Rows[0]["FMaterialId"].ToString());
            //    entity.FNumber = pFNumber;
            //    entity.FName = dt.Rows[0]["FName"] == null ? "" : dt.Rows[0]["FName"].ToString();
            //    entity.FUseOrgId = dt.Rows[0]["FUseOrgId"] == null ? 0 : int.Parse(dt.Rows[0]["FUseOrgId"].ToString());
            //    entity.FGroupId = dt.Rows[0]["FGroupId"] == null ? 0 : int.Parse(dt.Rows[0]["FGroupId"].ToString());
            //    entity.FDocumentStatus = dt.Rows[0]["FDocumentStatus"] == null ? ' ' : char.Parse(dt.Rows[0]["FDocumentStatus"].ToString());
            //    entity.FForbidStatus = dt.Rows[0]["FForbidStatus"] == null ? ' ' : char.Parse(dt.Rows[0]["FForbidStatus"].ToString());

            //    entity.F_PAEZ_BRAND = dt.Rows[0]["F_PAEZ_BRAND"] == null ? "" : dt.Rows[0]["F_PAEZ_BRAND"].ToString();
            //    entity.F_PAEZ_SERIES = dt.Rows[0]["F_PAEZ_SERIES"] == null ? "" : dt.Rows[0]["F_PAEZ_SERIES"].ToString();
            //    entity.F_PAEZ_TRADE = dt.Rows[0]["F_PAEZ_TRADE"] == null ? "" : dt.Rows[0]["F_PAEZ_TRADE"].ToString();
            //    entity.F_PAEZ_CARSERIES = dt.Rows[0]["F_PAEZ_CARSERIES"] == null ? "" : dt.Rows[0]["F_PAEZ_CARSERIES"].ToString();
            //    entity.F_PAEZ_CARTYPE = dt.Rows[0]["F_PAEZ_CARTYPE"] == null ? "" : dt.Rows[0]["F_PAEZ_CARTYPE"].ToString();
            //    entity.F_PAEZ_COLOR = dt.Rows[0]["F_PAEZ_COLOR"] == null ? "" : dt.Rows[0]["F_PAEZ_COLOR"].ToString();

            //    entity.Creator = dt.Rows[0]["Creator"] == null ? "" : dt.Rows[0]["Creator"].ToString();
            //    entity.CreationDate = dt.Rows[0]["CreationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["CreationDate"].ToString());
            //    entity.Modifier = dt.Rows[0]["Modifier"] == null ? "" : dt.Rows[0]["Modifier"].ToString();
            //    entity.ModificationDate = dt.Rows[0]["ModificationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["ModificationDate"].ToString());
            //    entity.Flag = true;
            //    entity.Description = dt.Rows[0]["Description"] == null ? "" : dt.Rows[0]["Description"].ToString();

            //    return entity;
            //}

            MaterialInfo entry = new MaterialInfo();
            K3CloudApiClient client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);

            if (bLogin)
            {
                try
                {
                    string strJson = "{\"FormId\":\"BD_MATERIAL\",\"FieldKeys\":\"FMaterialId,FName,FMaterialGroup,F_PAEZ_Brand.FDataValue,F_PAEZ_Series.FDataValue,F_PAEZ_Trade.FDataValue,F_PAEZ_Carseries.FDataValue,F_PAEZ_Cartype.FDataValue,F_PAEZ_Color.FDataValue,FCreateDate,FModifyDate,FDescription\",\"FilterString\":\"FNumber = '" + pFNumber + "' AND FUseOrgId = 100508 AND FDocumentStatus = 'C' AND FForbidStatus = 'A'\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
                    List<List<object>> list = client.ExecuteBillQuery(strJson);
                    if (list.Count > 0)
                    {
                        entry.FMaterialId = int.Parse(list[0][0].ToString());
                        entry.FNumber = pFNumber;
                        entry.FName = list[0][1].ToString();
                        entry.FUseOrgId = 100508;
                        entry.FGroupId = int.Parse(list[0][2].ToString());

                        entry.FDocumentStatus = 'C';
                        entry.FForbidStatus = 'A';
                        entry.F_PAEZ_BRAND = list[0][3] == null ? "" : list[0][3].ToString();
                        entry.F_PAEZ_SERIES = list[0][4] == null ? "" : list[0][4].ToString();
                        entry.F_PAEZ_TRADE = list[0][5] == null ? "" : list[0][5].ToString();

                        entry.F_PAEZ_CARSERIES = list[0][6] == null ? "" : list[0][6].ToString();
                        entry.F_PAEZ_CARTYPE = list[0][7] == null ? "" : list[0][7].ToString();
                        entry.F_PAEZ_COLOR = list[0][8] == null ? "" : list[0][8].ToString();
                        entry.Creator = "";
                        entry.CreationDate = DateTime.Parse(list[0][9].ToString());

                        entry.Modifier = "";
                        entry.ModificationDate = DateTime.Parse(list[0][10].ToString());
                        entry.Flag = true;
                        entry.Description = list[0][11].ToString();

                    }
                    else
                        return null;
                }
                catch
                {
                    return null;
                }
            }
            return entry;
        }

        /// <summary>
        /// 根据条码获取操作日志信息
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        internal static OperationInfo GetOperationInfoByBarcode(string pBarcode)
        {
            OperationInfo entity;
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@Barcode",SqlDbType.VarChar)
            };
            parms[0].Value = pBarcode;

            strSQL = "SELECT PID,Barcode,FID,FBillNo,OperatorId,Operator,Client,IP,MAC,Creator,CreationDate,Flag,Description  FROM Log_Operation WHERE Barcode = @Barcode";

            DataTable dt = SQLHelper.ExecuteTable(strSQL, parms);

            if (dt == null || dt.Rows.Count == 0)
                return null;
            else
            {
                entity = new OperationInfo();

                entity.PID = int.Parse(dt.Rows[0]["PID"].ToString());
                entity.Barcode = pBarcode;
                entity.FID = dt.Rows[0]["FID"] == null ? 0 : int.Parse(dt.Rows[0]["FID"].ToString());
                entity.FBillNo = dt.Rows[0]["FBillNo"] == null ? "" : dt.Rows[0]["FBillNo"].ToString();
                entity.OperatorId = dt.Rows[0]["OperatorId"] == null ? 0 : int.Parse(dt.Rows[0]["OperatorId"].ToString());
                entity.Operator = dt.Rows[0]["Operator"] == null ? "" : dt.Rows[0]["Operator"].ToString();
                entity.Client = dt.Rows[0]["Client"] == null ? "" : dt.Rows[0]["Client"].ToString();
                entity.IP = dt.Rows[0]["IP"] == null ? "" : dt.Rows[0]["IP"].ToString();
                entity.MAC = dt.Rows[0]["MAC"] == null ? "" : dt.Rows[0]["MAC"].ToString();

                entity.Creator = dt.Rows[0]["Creator"] == null ? "" : dt.Rows[0]["Creator"].ToString();
                entity.CreationDate = dt.Rows[0]["CreationDate"] == null ? DateTime.Parse("2012-12-31") : DateTime.Parse(dt.Rows[0]["CreationDate"].ToString());
                entity.Flag = dt.Rows[0]["Flag"] == null ? byte.Parse("0") : byte.Parse(dt.Rows[0]["Flag"].ToString());
                entity.Description = dt.Rows[0]["Description"] == null ? "" : dt.Rows[0]["Description"].ToString();

                return entity;
            }
        }

        /// <summary>
        /// 获取日志
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <param name="pFBillNo"></param>
        /// <param name="pOperator"></param>
        /// <param name="pFrom"></param>
        /// <param name="pTo"></param>
        /// <returns></returns>
        internal static DataTable GetOperations(string pBarcode, string pFBillNo, string pOperator, DateTime pFrom, DateTime pTo)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@Barcode",SqlDbType.VarChar),
                new SqlParameter("@FBillNo",SqlDbType.VarChar),
                new SqlParameter("@Operator",SqlDbType.VarChar),
                new SqlParameter("@From",SqlDbType.DateTime),
                new SqlParameter("@To",SqlDbType.DateTime)
            };
            parms[0].Value = pBarcode == null ? string.Empty : pBarcode;
            parms[1].Value = pFBillNo == null ? string.Empty : pFBillNo;
            parms[2].Value = pOperator == null ? string.Empty : pOperator;
            parms[3].Value = pFrom == null ? DateTime.Now.Date : pFrom;
            parms[4].Value = pTo == null ? DateTime.Now : pTo;

            strSQL = "SELECT PID, Barcode, FID, FBillNo, OperatorId, Operator, Client, IP, MAC, Creator, CreationDate, Flag, Description  FROM Log_Operation WHERE CreationDate BETWEEN @From AND @To";
            if (pBarcode != null && !pBarcode.Trim().Equals(string.Empty))
                strSQL += " AND Barcode = @Barcode";
            if (pFBillNo != null && !pFBillNo.Trim().Equals(string.Empty))
                strSQL += " AND FBillNo = @FBillNo";
            if (pOperator != null && !pOperator.Trim().Equals(string.Empty))
                strSQL += " AND Operator = @Operator";
            strSQL += " ORDER BY CreationDate DESC";

            return SQLHelper.ExecuteTable(strSQL, parms);
        }

        /// <summary>
        /// 写入操作日志
        /// </summary>
        /// <param name="pOperation"></param>
        internal static void Log_Operation(OperationInfo pOperation)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@Barcode",SqlDbType.VarChar),
                new SqlParameter("@FID",SqlDbType.Int),
                new SqlParameter("@FBillNo",SqlDbType.VarChar),
                new SqlParameter("@OperatorId",SqlDbType.Int),
                new SqlParameter("@Operator",SqlDbType.VarChar),

                new SqlParameter("@Client",SqlDbType.VarChar),
                new SqlParameter("@IP",SqlDbType.VarChar),
                new SqlParameter("@MAC",SqlDbType.VarChar),

                new SqlParameter("@Flag",SqlDbType.TinyInt),
                new SqlParameter("@Description",SqlDbType.VarChar)
            };
            parms[0].Value = pOperation.Barcode;
            parms[1].Value = pOperation.FID;
            parms[2].Value = pOperation.FBillNo;
            parms[3].Value = pOperation.OperatorId;
            parms[4].Value = pOperation.Operator;

            parms[5].Value = Dns.GetHostName();
            parms[6].Value = GetLocalIP();
            parms[7].Value = GetMac();

            parms[8].Value = pOperation.Flag;
            parms[9].Value = pOperation.Description;

            strSQL = @"INSERT INTO Log_Operation(Barcode,FID,FBillNo,OperatorId,Operator,Client,IP,MAC,Creator,CreationDate,Flag,Description)
            VALUES(@Barcode,@FID,@FBillNo,@OperatorId,@Operator,@Client,@IP,@MAC,@Operator,GETDATE(),@Flag,@Description)";

            SQLHelper.ExecuteNonQuery(strSQL, parms);
        }

        /// <summary>
        /// 更新模板
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pContext"></param>
        internal static void MergeTemplate(string pFileName, byte[] pContext)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@FileName",SqlDbType.VarChar),
                new SqlParameter("@Context", SqlDbType.Binary, pContext.Length)
            };
            parms[0].Value = pFileName;
            parms[1].Value = pContext;

            strSQL = @"MERGE INTO DM_Template AS T
            USING
            (
                SELECT @FileName FileName,@Context Context
            ) AS O ON T.FileName = O.FileName
            WHEN MATCHED
                THEN UPDATE SET Context = O.Context
            WHEN NOT MATCHED
                THEN INSERT(FileName,Context) VALUES(O.FileName,O.Context);";

            SQLHelper.ExecuteNonQuery(strSQL, parms);
        }
        /// <summary>
        /// 获取模板信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        internal static Template_DrawingInfo GetTemplateInfoByName(string pName)
        {
            DataTable dt;
            Template_DrawingInfo entry = new Template_DrawingInfo();

            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@FileName",SqlDbType.VarChar)
            };
            parms[0].Value = pName;

            strSQL = "SELECT FileName,Description,Context FROM DM_Template WHERE FileName = @FileName";

            dt = SQLHelper.ExecuteTable(strSQL, parms);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            try
            {
                entry.FileName = dt.Rows[0]["FileName"].ToString();
                entry.Description = dt.Rows[0]["Description"].ToString();
                entry.Context = (byte[])dt.Rows[0]["Context"];
            }
            catch //(Exception ex)
            {
                return null;
            }

            return entry;
        }

        #region OVE
        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        internal static string EncryptData(string pPassword)
        {
            return DataEncoder.EncryptData(pPassword);
        }

        /// <summary>
        /// 密码解密
        /// </summary>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        internal static string DecryptData(string pPassword)
        {
            return DataEncoder.DecryptData(pPassword);
        }

        #region Private Func
        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        /// <returns></returns>
        private static string GetLocalIP()
        {
            //string strIP = string.Empty;
            //try
            //{
            //    string hostInfo = Dns.GetHostName();
            //    IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            //    for (int i = 0; i < addressList.Length; i++)
            //    {
            //        strIP += addressList[i].ToString();
            //    }
            //}
            //catch { return string.Empty; }
            //return strIP;
            //pIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault<IPAddress>(a => a.AddressFamily.ToString().Equals("InterNetwork")).ToString();

            string strIP = string.Empty;
            try
            {
                string hostInfo = Dns.GetHostName();
                IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
                for (int i = 0; i < addressList.Length; i++)
                {
                    if (addressList[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        strIP = addressList[i].ToString();
                        break;
                    }
                }
            }
            catch { return string.Empty; }
            return strIP;
        }

        /// <summary>
        /// 获取本机MAC地址
        /// </summary>
        /// <returns></returns>
        private static string GetMac()
        {
            string Mac = string.Empty;
            try
            {
                NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in nis)
                {
                    if (ni.NetworkInterfaceType.ToString().Equals("Ethernet")) //是以太网卡
                    {
                        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + ni.Id + "\\Connection", false);

                        if (registryKey != null)
                        {
                            string fPnpInstanceID = registryKey.GetValue("PnpInstanceID", "").ToString();
                            //int fMediaSubType = Convert.ToInt32(registryKey.GetValue("MediaSubType", 0));
                            if (fPnpInstanceID.Length > 3 && fPnpInstanceID.Substring(0, 3) == "PCI") //是物理网卡
                            {
                                Mac = ni.GetPhysicalAddress().ToString();
                                break;
                            }
                            //else if (fMediaSubType == 1) //虚拟网卡
                            //    continue;
                            //else if (fMediaSubType == 2) //无线网卡(上面判断Ethernet时已经排除了)
                            //    continue;
                        }
                    }
                }
            }
            catch { return string.Empty; }
            return Mac;
        }
        #endregion
        #endregion
    }
}
