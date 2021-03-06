﻿using System;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using Kingdee.BOS.WebApi.Client;
using CBSys.WinForm.Model;

namespace CBSys.WinForm.Unity
{
    /// <summary>
    /// 通用方法
    /// </summary>
    internal static class CommonFunc
    {
        #region Fileds & Constructor
        private static string _sql;
        private static object _obj;

        /// <summary>
        /// 构造函数
        /// </summary>
        static CommonFunc()
        {
            _sql = string.Empty;
            _obj = new object();
        }
        #endregion

        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        internal static UserInfo GetUserInfoByName(string pName)
        {
            UserInfo entry;
            K3CloudApiClient client = new K3CloudApiClient(UserSetting.K3CloudInf.C_URL);
            bool bLogin = client.Login(UserSetting.K3CloudInf.C_ZTID, UserSetting.K3CloudInf.C_USERNAME, UserSetting.K3CloudInf.C_PWD, 2052);
            string strJson = "{\"FormId\":\"BD_Empinfo\",\"FieldKeys\":\"FNAME,FNumber,FPERSONID,FSTAFFID,FPOSTDEPT,FUseOrgId\",\"FilterString\":\"FNAME = '" + UserSetting.K3CloudInf.C_USERNAME + "'\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";

            if (bLogin)
            {
                try
                {
                    List<List<object>> list = client.ExecuteBillQuery(strJson);

                    entry = new UserInfo();
                    entry.UserName = UserSetting.K3CloudInf.C_USERNAME;
                    entry.FNumber = list[0][1].ToString();
                    entry.PersonId = list[0][2] == null ? 0 : int.Parse(list[0][2].ToString());
                    entry.StaffId = list[0][3] == null ? 0 : int.Parse(list[0][3].ToString());
                    entry.FDeptId = list[0][4] == null ? 0 : int.Parse(list[0][4].ToString());
                    entry.UseOrgId = list[0][5] == null ? 100508 : int.Parse(list[0][5].ToString());
                    return entry;
                }
                catch
                {
                    return null;
                }
            }
            return null;
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
        /// 根据源路径获取图纸信息
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <returns></returns>
        internal static DrawingInfo GetDrawing(string pSourcePath)
        {
            DataTable dt;
            DrawingInfo entry;

            _sql = "SELECT PID,FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,CreationDate,Flag,IsDelete,Description,Context FROM BD_Drawing WHERE IsDelete = 0 AND SourcePath = '" + pSourcePath + "'";

            try
            {
                dt = SQLHelper.ExecuteTable(_sql);

                entry = new DrawingInfo();
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

                return entry;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取图纸信息
        /// </summary>
        /// <param name="pSourcePathList">SourcePathList</param>
        /// <returns></returns>
        internal static List<DrawingInfo> GetDrawing(List<string> pSourcePathList)
        {
            DataTable dt;
            DrawingInfo entry;
            List<DrawingInfo> list;

            if (pSourcePathList == null || pSourcePathList.Count == 0)
                return null;

            _sql = "SELECT PID,FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,CreationDate,Flag,IsDelete,Description,Context FROM BD_Drawing WHERE IsDelete = 0 AND SourcePath IN(";
            for (int i = 0; i < pSourcePathList.Count; i++)
            {
                if (!pSourcePathList[i].Equals(string.Empty))
                    _sql += "'" + pSourcePathList[i] + "',";
            }
            _sql = _sql.Substring(0, _sql.Length - 1);
            _sql += ")";

            try
            {
                list = new List<DrawingInfo>();
                dt = SQLHelper.ExecuteTable(_sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    entry = new DrawingInfo();
                    entry.PID = int.Parse(dt.Rows[i]["PID"].ToString());
                    entry.FMaterialId = int.Parse(dt.Rows[i]["FMaterialId"].ToString());
                    entry.FNumber = dt.Rows[i]["FNumber"].ToString();
                    entry.FileName = dt.Rows[i]["FileName"].ToString();
                    entry.FileSuffix = dt.Rows[i]["FileSuffix"].ToString();

                    entry.FileSize = long.Parse(dt.Rows[i]["FileSize"].ToString());
                    entry.SourcePath = dt.Rows[i]["SourcePath"].ToString();
                    entry.Creator = dt.Rows[i]["Creator"].ToString();
                    entry.CreationDate = DateTime.Parse(dt.Rows[i]["CreationDate"].ToString());
                    entry.Flag = bool.Parse(dt.Rows[i]["Flag"].ToString());

                    entry.IsDelete = bool.Parse(dt.Rows[i]["IsDelete"].ToString());
                    entry.Description = dt.Rows[i]["Description"].ToString();
                    entry.Context = (byte[])dt.Rows[i]["Context"];

                    list.Add(entry);
                }

                return list;
            }
            catch { return null; }
        }

        /// <summary>
        /// 获取图纸信息
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pGeneral"></param>
        /// <returns></returns>
        internal static DataTable GetDrawing(string pFileName, bool? pFlag, int pIsNull, string pTrade)
        {
            if (!pFileName.Trim().Equals(string.Empty))
            {
                _sql = @"SELECT DR.PID,DR.[FileName] 图纸,ISNULL(RL.F_PAEZ_TRADE,'') 商品名,ISNULL(RL.F_PAEZ_CARSERIES,'') 车系,ISNULL(RL.F_PAEZ_CARTYPE,'') 车型,ISNULL(RL.CategoryId,'') 类型
	                ,CASE ISNULL(DR.Flag,0) WHEN 0 THEN '否' ELSE '是' END 锁定,DR.[Description] 描述,DR.SourcePath 源路
                FROM BD_Drawing DR
                LEFT JOIN BD_Drawing_RL RL ON RL.SourcePath = DR.SourcePath
                WHERE DR.IsDelete = 0 AND DR.FileName LIKE '%" + pFileName + "%'";

                if (!pTrade.Equals(string.Empty))
                    _sql += " AND RL.F_PAEZ_TRADE LIKE '%" + pTrade + "%'";

                if (pIsNull == 1)
                    _sql += " AND RL.F_PAEZ_TRADE IS NULL";
                else if (pIsNull == 2)
                    _sql += " AND RL.F_PAEZ_TRADE IS NOT NULL";

                return SQLHelper.ExecuteTable(_sql);
            }

            return null;
        }

        /// <summary>
        /// 获取图纸信息
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pGeneral"></param>
        /// <param name="pArt"></param>
        /// <param name="pCust"></param>
        /// <returns></returns>
        internal static DataTable GetDrawing(string pFileName, bool pGeneral, bool pArt, bool pCust)
        {
            if (UserSetting.IsFenChang)
            {
                SqlParameter[] parms = new SqlParameter[]
                {
                    new SqlParameter("@OrgId", SqlDbType.VarChar),
                    new SqlParameter("@FileName", SqlDbType.VarChar),
                    new SqlParameter("@General", SqlDbType.Bit),
                    new SqlParameter("@Art", SqlDbType.Bit),
                    new SqlParameter("@Cust", SqlDbType.Bit)
                };
                parms[0].Value = UserSetting.UserInf.UseOrgId.ToString();
                parms[1].Value = pFileName;
                parms[2].Value = pGeneral ? 1 : 0;
                parms[3].Value = pArt ? 1 : 0;
                parms[4].Value = pCust ? 1 : 0;

                return SQLHelper.ExecuteTable("DM_GetDrawingByOrder", CommandType.StoredProcedure, parms);
            }
            else
            {
                SqlParameter[] parms = new SqlParameter[]
                {
                    new SqlParameter("@DeptId", SqlDbType.VarChar),
                    new SqlParameter("@FileName", SqlDbType.VarChar),
                    new SqlParameter("@General", SqlDbType.Bit),
                    new SqlParameter("@Art", SqlDbType.Bit),
                    new SqlParameter("@Cust", SqlDbType.Bit)
                };
                parms[0].Value = UserSetting.UserInf.FDeptId.ToString();
                parms[1].Value = pFileName;
                parms[2].Value = pGeneral ? 1 : 0;
                parms[3].Value = pArt ? 1 : 0;
                parms[4].Value = pCust ? 1 : 0;

                return SQLHelper.ExecuteTable("DM_GetDrawingByDEPT", CommandType.StoredProcedure, parms);
            }
        }

        /// <summary>
        /// 检查Drawing文件名是否存在
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <returns></returns>
        internal static bool Check_DrawingFileName(string pSourcePath)
        {
            _obj = SQLHelper.ExecuteScalar("SELECT COUNT(*) FROM BD_Drawing WHERE IsDelete = 0 AND SourcePath = '" + pSourcePath + "'");

            if ((int)_obj > 0) return true;

            return false;
        }

        /// <summary>
        /// 删除图纸
        /// </summary>
        /// <param name="pSourcePath"></param>
        internal static void DeleteDrawing(string pSourcePath)
        {
            SQLHelper.ExecuteNonQuery("UPDATE BD_Drawing SET IsDelete = 1 WHERE SourcePath = '" + pSourcePath + "'");
        }

        /// <summary>
        /// 更新图纸-编辑
        /// </summary>
        /// <param name="pEntry"></param>
        internal static void UpdateDrawing(int pPID, string pFileName, string pSourcePath)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@PID", SqlDbType.Int),
                new SqlParameter("@FileName", SqlDbType.VarChar),
                new SqlParameter("@SourcePath", SqlDbType.VarChar),
                new SqlParameter("@Creator", SqlDbType.VarChar)
            };
            parms[0].Value = pPID;
            parms[1].Value = pFileName;
            parms[2].Value = pSourcePath;
            parms[3].Value = UserSetting.UserInf.UserName;

            _sql = "UPDATE BD_Drawing SET FileName = @FileName,SourcePath = @SourcePath,Creator = @Creator,CreationDate = GETDATE(),Description = '修改-图纸更新' WHERE PID = @PID";

            SQLHelper.ExecuteNonQuery(_sql, parms);
        }

        /// <summary>
        /// 更新图纸-导入
        /// </summary>
        /// <param name="pDrawingInf"></param>
        internal static void UpdateDrawing(DrawingInfo pDrawingInf)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@PID",SqlDbType.Int),
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
            parms[0].Value = pDrawingInf.PID;
            parms[1].Value = pDrawingInf.FMaterialId;
            parms[2].Value = pDrawingInf.FNumber;
            parms[3].Value = pDrawingInf.FileName;
            parms[4].Value = pDrawingInf.FileSuffix;

            parms[5].Value = pDrawingInf.FileSize;
            parms[6].Value = pDrawingInf.SourcePath;
            parms[7].Value = pDrawingInf.Creator;
            parms[8].Value = pDrawingInf.Description;
            parms[9].Value = pDrawingInf.Context;

            if (pDrawingInf.PID != 0)
                _sql = @"UPDATE BD_Drawing SET IsDelete = 1 WHERE PID = @PID;
                INSERT INTO BD_Drawing(FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,Description,Context)
                VALUES(@FMaterialId,@FNumber,@FileName,@FileSuffix,@FileSize,@SourcePath,@Creator,@Description,@Context);";
            else
                _sql = @"UPDATE BD_Drawing SET IsDelete = 1 WHERE SourcePath = @SourcePath;
                INSERT INTO BD_Drawing(FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,Description,Context)
                VALUES(@FMaterialId,@FNumber,@FileName,@FileSuffix,@FileSize,@SourcePath,@Creator,@Description,@Context);";

            SQLHelper.ExecuteNonQuery(_sql, parms);
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

            _sql = @"INSERT INTO BD_Drawing(FMaterialId,FNumber,FileName,FileSuffix,FileSize,SourcePath,Creator,Description,Context)
            VALUES(@FMaterialId,@FNumber,@FileName,@FileSuffix,@FileSize,@SourcePath,@Creator,@Description,@Context)";

            SQLHelper.ExecuteNonQuery(_sql, parms);
        }

        /// <summary>
        /// Merge MTLDrawing
        /// </summary>
        /// <param name="pMTLDrawingInf"></param>
        internal static void MergeMTLDrawing(MTLDrawingInfo pMTLDrawingInf)
        {
            pMTLDrawingInf.Barcode = pMTLDrawingInf.Barcode == null ? "" : pMTLDrawingInf.Barcode;
            pMTLDrawingInf.FNumber = pMTLDrawingInf.FNumber == null ? "" : pMTLDrawingInf.FNumber;
            pMTLDrawingInf.F_PAEZ_TRADE = pMTLDrawingInf.F_PAEZ_TRADE == null ? "" : pMTLDrawingInf.F_PAEZ_TRADE;
            pMTLDrawingInf.F_PAEZ_CARSERIES = pMTLDrawingInf.F_PAEZ_CARSERIES == null ? "" : pMTLDrawingInf.F_PAEZ_CARSERIES;
            pMTLDrawingInf.F_PAEZ_CARTYPE = pMTLDrawingInf.F_PAEZ_CARTYPE == null ? "" : pMTLDrawingInf.F_PAEZ_CARTYPE;
            pMTLDrawingInf.Description = pMTLDrawingInf.Description == null ? "" : pMTLDrawingInf.Description;

            _sql = @"MERGE INTO BD_Drawing_RL AS T
            USING
            (
             SELECT " + pMTLDrawingInf.CategoryId + " CategoryId,'" + pMTLDrawingInf.SourcePath + "' SourcePath,'" + pMTLDrawingInf.Barcode + "' Barcode," + pMTLDrawingInf.FMaterialId + " FMaterialId,'" + pMTLDrawingInf.FNumber + "' FNumber,'" + pMTLDrawingInf.F_PAEZ_TRADE + "' F_PAEZ_TRADE,'" + pMTLDrawingInf.F_PAEZ_CARSERIES + "' F_PAEZ_CARSERIES,'" + pMTLDrawingInf.F_PAEZ_CARTYPE + "' F_PAEZ_CARTYPE,1 Flag,'" + pMTLDrawingInf.Description + @"' Description
            ) AS O 
            ON T.SourcePath = O.SourcePath AND T.F_PAEZ_TRADE = O.F_PAEZ_TRADE AND T.F_PAEZ_CARSERIES = O.F_PAEZ_CARSERIES AND T.F_PAEZ_CARTYPE = O.F_PAEZ_CARTYPE
            WHEN MATCHED AND T.IsDelete = 0
                THEN UPDATE SET
                CategoryId = O.CategoryId,Barcode = O.Barcode,FMaterialId = O.FMaterialId,FNumber = O.FNumber,Flag = O.Flag,Description = O.Description
            WHEN NOT MATCHED
                THEN INSERT(CategoryId,SourcePath,Barcode,FMaterialId,FNumber,F_PAEZ_TRADE,F_PAEZ_CARSERIES,F_PAEZ_CARTYPE,Flag,Description)
                VALUES(O.CategoryId,O.SourcePath,O.Barcode,O.FMaterialId,O.FNumber,O.F_PAEZ_TRADE,O.F_PAEZ_CARSERIES,O.F_PAEZ_CARTYPE,O.Flag,O.Description);";

            SQLHelper.ExecuteNonQuery(_sql);
        }

        /// <summary>
        /// 修改图纸锁定状态
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <param name="pStatus"></param>
        internal static void LockDrawing(string pSourcePath, bool pStatus)
        {
            int iFlag = pStatus ? 1 : 0;

            SQLHelper.ExecuteNonQuery("UPDATE BD_Drawing SET Flag = " + iFlag + " WHERE IsDelete = 0 AND SourcePath = '" + pSourcePath + "'");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pR_Type"></param>
        /// <returns></returns>
        internal static Drawing_RInfo GetDrawing_RInfo(string pR_Type)
        {
            DataTable dt;
            Drawing_RInfo entry;

            try
            {
                dt = SQLHelper.ExecuteTable("SELECT PID,R_Type,M_Users,Managers,U_Users,D_Users,U_Users2,D_Users2,U_Users3,D_Users3,Operator,OTime,Description FROM BD_Drawing_R WHERE R_Type = '" + pR_Type + "'");

                entry = new Drawing_RInfo();
                entry.PID = int.Parse(dt.Rows[0]["PID"].ToString());
                entry.R_Type = pR_Type;
                entry.M_Users = dt.Rows[0]["M_Users"].ToString();
                entry.Managers = dt.Rows[0]["Managers"].ToString();
                entry.U_Users = dt.Rows[0]["U_Users"].ToString();
                entry.D_Users = dt.Rows[0]["D_Users"].ToString();
                entry.U_Users2 = dt.Rows[0]["U_Users2"].ToString();
                entry.D_Users2 = dt.Rows[0]["D_Users2"].ToString();
                entry.U_Users3 = dt.Rows[0]["U_Users3"].ToString();
                entry.D_Users3 = dt.Rows[0]["D_Users3"].ToString();
                entry.Operator = dt.Rows[0]["Operator"].ToString();
                entry.OTime = DateTime.Parse(dt.Rows[0]["OTime"].ToString());
                entry.Description = dt.Rows[0]["Description"].ToString();

                return entry;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        internal static void ModifyDrawing_RInfo()
        {
            _sql = "UPDATE BD_Drawing_R SET Managers = '" + UserSetting.Drawing_RInf.Managers + "',U_Users = '" + UserSetting.Drawing_RInf.U_Users + "',D_Users = '" + UserSetting.Drawing_RInf.D_Users + "',U_Users2 = '" + UserSetting.Drawing_RInf.U_Users2 + "' WHERE PID = " + UserSetting.Drawing_RInf.PID;
            SQLHelper.ExecuteNonQuery(_sql);
        }
        
        /// <summary>
        /// 图纸关联关系总数
        /// </summary>
        /// <returns></returns>
        internal static int GetDrawing_RL_Count()
        {
            return int.Parse(SQLHelper.ExecuteScalar("SELECT COUNT(*) FROM BD_Drawing_RL WHERE IsDelete = 0").ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pTrade"></param>
        /// <param name="pCarSeries"></param>
        /// <param name="pCarType"></param>
        /// <returns></returns>
        internal static DataTable GetDrawing_RL(string pTrade, string pCarSeries, string pCarType)
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@F_PAEZ_TRADE", SqlDbType.VarChar),
                new SqlParameter("@F_PAEZ_CARSERIES", SqlDbType.VarChar),
                new SqlParameter("@F_PAEZ_CARTYPE", SqlDbType.VarChar)
            };
            parms[0].Value = pTrade;
            parms[1].Value = pCarSeries;
            parms[2].Value = pCarType;

            return SQLHelper.ExecuteTable("DM_GetDrawing_RL", CommandType.StoredProcedure, parms);
        }

        /// <summary>
        /// 删除图纸关联关系
        /// </summary>
        /// <param name="pSourcePath"></param>
        internal static void DeleteDrawing_RL(int pPID)
        {
            SQLHelper.ExecuteNonQuery("UPDATE BD_Drawing_RL SET IsDelete = 1 WHERE PID = " + pPID);
        }

        /// <summary>
        /// 清除无效图纸关联关系
        /// </summary>
        internal static void ClearDrawing_RL()
        {
            _sql = @"UPDATE rl SET rl.IsDelete = 1
            FROM BD_Drawing_RL rl
            LEFT JOIN BD_Drawing dr ON rl.SourcePath = dr.SourcePath
            WHERE dr.PID is null AND rl.IsDelete = 0";

            SQLHelper.ExecuteNonQuery(_sql);
        }

        /// <summary>
        /// 判断图纸管理关系中-商品名，车系，车型是否存在
        /// </summary>
        /// <param name="pTrade"></param>
        /// <param name="pCarSeries"></param>
        /// <param name="pCarType"></param>
        /// <returns></returns>
        internal static bool CheckDrawing_RL_UK(string pTrade, string pCarSeries, string pCarType)
        {
            _sql = "SELECT COUNT(*) FROM BD_Drawing_RL WHERE IsDelete = 0 AND F_PAEZ_TRADE = '" + pTrade + "' AND F_PAEZ_CARSERIES = '" + pCarSeries + "' AND F_PAEZ_CARTYPE = '" + pCarType + "'";

            _obj = SQLHelper.ExecuteScalar(_sql);
            if (_obj != null && _obj.ToString() != "0")
                return false;
            else
                return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFromType"></param>
        /// <param name="pPID"></param>
        /// <param name="pTrade"></param>
        /// <param name="pCarSeries"></param>
        /// <param name="pCarType"></param>
        /// <param name="pSourcePath"></param>
        /// <param name="pCategoryID"></param>
        internal static void EditDrawing_RL(string pFromType, int pPID, string pTrade, string pCarSeries, string pCarType, string pSourcePath, int pCategoryID)
        {
            if (pFromType == "Add")
                _sql = @"INSERT INTO BD_Drawing_RL(CategoryId,SourcePath,F_PAEZ_TRADE,F_PAEZ_CARSERIES,F_PAEZ_CARTYPE)
                VALUES(" + pCategoryID + ",'" + pSourcePath + "','" + pTrade + "','" + pCarSeries + "','" + pCarType + "')";
            else if (pFromType == "Edit")
                _sql = "UPDATE BD_Drawing_RL SET F_PAEZ_TRADE = '" + pTrade + "',F_PAEZ_CARSERIES = '" + pCarSeries + "',F_PAEZ_CARTYPE = '" + pCarType + "',SourcePath = '" + pSourcePath + "',CategoryId = " + pCategoryID + " WHERE PID = " + pPID;

            SQLHelper.ExecuteNonQuery(_sql);
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

            _sql = @"MERGE INTO DM_Template AS T
            USING
            (
                SELECT @FileName FileName,@Context Context
            ) AS O ON T.FileName = O.FileName
            WHEN MATCHED
                THEN UPDATE SET Context = O.Context
            WHEN NOT MATCHED
                THEN INSERT(FileName,Context) VALUES(O.FileName,O.Context);";

            SQLHelper.ExecuteNonQuery(_sql, parms);
        }
        /// <summary>
        /// 获取模板信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        internal static Template_DrawingInfo GetTemplateInfoByName(string pName)
        {
            DataTable dt;
            Template_DrawingInfo entry;

            SqlParameter[] parms = new SqlParameter[] { new SqlParameter("@FileName", SqlDbType.VarChar) };
            parms[0].Value = pName;

            try
            {
                dt = SQLHelper.ExecuteTable("SELECT FileName,Description,Context FROM DM_Template WHERE FileName = @FileName", parms);

                entry = new Template_DrawingInfo();
                entry.FileName = dt.Rows[0]["FileName"].ToString();
                entry.Description = dt.Rows[0]["Description"].ToString();
                entry.Context = (byte[])dt.Rows[0]["Context"];
                return entry;
            }
            catch
            {
                return null;
            }
        }

        #region OVE
        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="pPassword"></param>
        /// <returns></returns>

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

        /// <summary>
        /// 关闭指定进程
        /// </summary>
        internal static void KillPro(string pProcessName)
        {
            Process[] pro = Process.GetProcesses();//获取已开启的所有进程

            pProcessName = pProcessName.Trim().ToUpper();

            //遍历所有查找到的进程
            for (int i = 0; i < pro.Length; i++)
            {
                //判断此进程是否是要查找的进程
                if (pro[i].ProcessName.ToString().ToUpper() == pProcessName)
                {
                    pro[i].Kill();//结束进程
                    break;
                }
            }
        }
        #endregion
        #endregion

        #region Wait

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

            _sql = "UPDATE BD_Users SET LogStatus = @LogStatus,LastLoginDate = GETDATE() WHERE UserName = @UserName";

            SQLHelper.ExecuteNonQuery(_sql, parms);
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

            _sql = "SELECT PID,Barcode,FID,FBillNo,FDate,FEntryId,FNumber,FQTY,FSEQ,GroupId,Times,Creator,CreationDate,Modifier,ModificationDate,Flag,Description  FROM PRD_Mo WHERE Barcode = @Barcode";

            DataTable dt = SQLHelper.ExecuteTable(_sql, parms);

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
        /// 根据物料编码获取物料信息
        /// </summary>
        /// <param name="pFNumber"></param>
        /// <returns></returns>
        internal static MaterialInfo GetMaterialInfoByFNumber(string pFNumber)
        {
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

            _sql = "SELECT PID,FMaterialId,FNumber,SourcePath,FileName,FileSuffix,FileSize,Creator,CreationDate,Flag,IsDelete,Description  FROM BD_Drawing WHERE FNumber = @FNumber";

            DataTable dt = SQLHelper.ExecuteTable(_sql, parms);

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

            _sql = @"MERGE INTO BD_Drawing AS T
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

            SQLHelper.ExecuteNonQuery(_sql, parms);
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

            _sql = "SELECT PID,Barcode,FID,FBillNo,OperatorId,Operator,Client,IP,MAC,Creator,CreationDate,Flag,Description  FROM Log_Operation WHERE Barcode = @Barcode";

            DataTable dt = SQLHelper.ExecuteTable(_sql, parms);

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

            _sql = "SELECT PID, Barcode, FID, FBillNo, OperatorId, Operator, Client, IP, MAC, Creator, CreationDate, Flag, Description  FROM Log_Operation WHERE CreationDate BETWEEN @From AND @To";
            if (pBarcode != null && !pBarcode.Trim().Equals(string.Empty))
                _sql += " AND Barcode = @Barcode";
            if (pFBillNo != null && !pFBillNo.Trim().Equals(string.Empty))
                _sql += " AND FBillNo = @FBillNo";
            if (pOperator != null && !pOperator.Trim().Equals(string.Empty))
                _sql += " AND Operator = @Operator";
            _sql += " ORDER BY CreationDate DESC";

            return SQLHelper.ExecuteTable(_sql, parms);
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

            _sql = @"INSERT INTO Log_Operation(Barcode,FID,FBillNo,OperatorId,Operator,Client,IP,MAC,Creator,CreationDate,Flag,Description)
            VALUES(@Barcode,@FID,@FBillNo,@OperatorId,@Operator,@Client,@IP,@MAC,@Operator,GETDATE(),@Flag,@Description)";

            SQLHelper.ExecuteNonQuery(_sql, parms);
        }
        #endregion
    }
}
