using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using CBSys.WMSDyn.Model;
using CBSys.WMSDyn.Unity;

namespace CBSys.WMSDyn.SQL
{
    /// <summary>
    /// 接口实现
    /// </summary>
    public class Common : ICommon
    {
        #region Fields,Properties & Structor
        /// <summary>
        /// 构造函数-带默认数据库连接字符串
        /// </summary>
        public Common() { }
        #endregion

        /// <summary>
        /// 注销-当前用户
        /// </summary>
        public void UserLogout()
        {
            CommonFunction.UpdateLoginStatus(UserSetting.UserInf, false);
            UserSetting.UserInf = new UserInfo();
        }

        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByName(string pName)
        {
            return CommonFunction.GetUserInfoByName(pName);
        }

        /// <summary>
        /// 根据ID获取K3部门信息
        /// </summary>
        /// <param name="pDeptId"></param>
        /// <returns></returns>
        public DepartmentInfo GetDeptmentInfoById(int? pDeptId)
        {
            return CommonFunction.GetDeptmentInfoById(pDeptId);
        }

        /// <summary>
        /// 获取当前用户所有条码
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserDrawing()
        {
            return CommonFunction.GetUserDrawing(UserSetting.UserInf.UserName);
        }

        /// <summary>
        /// 根据条码查询图纸路径-当前用户
        /// </summary>
        /// <param name="pBarcode">条码</param>
        /// <returns></returns>
        public string GetUserDrawing(string pBarcode)
        {
            return CommonFunction.GetUserDrawing(UserSetting.UserInf.UserName, pBarcode);
        }

        /// <summary>
        /// 根据用户名和条码查询图纸路径-指定用户
        /// </summary>
        /// <param name="pName">用户名</param>
        /// <param name="pBarcode">条码</param>
        /// <returns></returns>
        public string GetUserDrawing(string pName, string pBarcode)
        {
            return CommonFunction.GetUserDrawing(pName, pBarcode);
        }

        /// <summary>
        /// 根据条码获取任务单信息
        /// </summary>
        /// <param name="pBarcode">条码</param>
        /// <returns></returns>
        public MoInfo GetMoInfoByBarcode(string pBarcode)
        {
            return CommonFunction.GetMoInfoByBarcode(pBarcode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDeptId"></param>
        /// <returns></returns>
        public List<string> GetFNumbersByDepartId(int pDeptId)
        {
            return CommonFunction.GetFNumbersByDepartId(pDeptId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFNumbers"></param>
        /// <returns></returns>
        public IList GetMTLListByFNumbers(List<string> pFNumbers)
        {
            return CommonFunction.GetMTLListByFNumbers(pFNumbers);
        }

        /// <summary>
        /// 根据物料编码获取图纸信息
        /// </summary>
        /// <param name="pFNumber">物料编码</param>
        /// <returns></returns>
        public DrawingInfo GetDrawingInfoByFNumber(string pFNumber)
        {
            return CommonFunction.GetDrawingInfoByFNumber(pFNumber);
        }

        /// <summary>
        /// 根据物料编码获取物料信息
        /// </summary>
        /// <param name="pFNumber">物料编码</param>
        /// <returns></returns>
        public MaterialInfo GetMaterialInfoByFNumber(string pFNumber)
        {
            return CommonFunction.GetMaterialInfoByFNumber(pFNumber);
        }

        /// <summary>
        /// 根据条码获取操作日志信息
        /// </summary>
        /// <param name="pBarcode">条码</param>
        /// <returns></returns>
        public OperationInfo GetOperationInfoByBarcode(string pBarcode)
        {
            return CommonFunction.GetOperationInfoByBarcode(pBarcode);
        }

        /// <summary>
        /// 获取日志信息
        /// </summary>
        /// <param name="pBarcode">条码</param>
        /// <param name="pFBillNo">任务单号</param>
        /// <param name="pOperator">操作员</param>
        /// <param name="pFrom">开始时间</param>
        /// <param name="pTo">结束时间</param>
        /// <returns></returns>
        public DataTable GetOperations(string pBarcode, string pFBillNo, string pOperator, DateTime pFrom, DateTime pTo)
        {
            return CommonFunction.GetOperations(pBarcode, pFBillNo, pOperator, pFrom, pTo);
        }

        /// <summary>
        /// 写入操作日志
        /// </summary>
        /// <param name="pOperation">操作日志实体</param>
        public void Log_Operation(OperationInfo pOperation)
        {
            CommonFunction.Log_Operation(pOperation);
        }

        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public string EncryptData(string pPassword)
        {
            return CommonFunction.EncryptData(pPassword);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDrawingInf"></param>
        public void UpLoadDrawing(DrawingInfo pDrawingInf)
        {
            CommonFunction.UpLoadDrawing(pDrawingInf);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDrawingInf"></param>
        public void UpdateDrawing(DrawingInfo pDrawingInf)
        {
            CommonFunction.UpdateDrawing(pDrawingInf);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDrawingInf"></param>
        public void MergeDrawing(DrawingInfo pDrawingInf)
        {
            CommonFunction.MergeDrawing(pDrawingInf);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMTLDrawingInf"></param>
        public void MergeMTLDrawing(MTLDrawingInfo pMTLDrawingInf)
        {
            CommonFunction.MergeMTLDrawing(pMTLDrawingInf);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSourcePath"></param>
        public void DeleteDrawing(string pSourcePath)
        {
            CommonFunction.DeleteDrawing(pSourcePath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <param name="pStatus"></param>
        public void LockDrawing(string pSourcePath, bool pStatus)
        {
            CommonFunction.LockDrawing(pSourcePath, pStatus);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <returns></returns>
        public bool Check_DrawingFileName(string pSourcePath)
        {
            return CommonFunction.Check_DrawingFileName(pSourcePath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        public DrawingInfo DownLoadDrawing(string pBarcode)
        {
            return CommonFunction.DownLoadDrawing(pBarcode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pContext"></param>
        public void MergeTemplate(string pFileName, byte[] pContext)
        {
            CommonFunction.MergeTemplate(pFileName, pContext);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Template_DrawingInfo GetTemplateInfoByName(string pName)
        {
            return CommonFunction.GetTemplateInfoByName(pName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetDrawing()
        {
            return CommonFunction.GetDrawing();
        }
    }
}
