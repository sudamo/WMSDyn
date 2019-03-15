using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using CBSys.WMSDyn.Model;

namespace CBSys.WMSDyn
{
    /// <summary>
    /// Common接口
    /// </summary>
    public interface ICommon
    {
        //string this[int index] { get; set; }
        //event EventHandler even;
        //UserInfo User
        //{
        //    get;
        //}

        /// <summary>
        /// 注销-当前用户
        /// </summary>
        void UserLogout();
        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        UserInfo GetUserInfoByName(string pName);
        /// <summary>
        /// 根据ID获取K3部门信息
        /// </summary>
        /// <param name="pDeptId"></param>
        /// <returns></returns>
        DepartmentInfo GetDeptmentInfoById(int? pDeptId);
        /// <summary>
        /// 根据用户名和条码查询图纸路径
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        string GetUserDrawing(string pBarcode);
        /// <summary>
        /// 根据用户名获取用户的所有条码
        /// </summary>
        /// <returns></returns>
        DataTable GetUserDrawing();
        /// <summary>
        /// 根据用户名和条码查询图纸路径-指定用户
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        string GetUserDrawing(string pName, string pBarcode);
        /// <summary>
        /// 根据条码获取任务单信息
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        MoInfo GetMoInfoByBarcode(string pBarcode);
        /// <summary>
        /// 根据生产车间ID获取当天该车间的生产订单物料编码
        /// </summary>
        /// <param name="pDeptId"></param>
        /// <returns></returns>
        List<string> GetFNumbersByDepartId(int pDeptId);
        /// <summary>
        /// 根据物料编码list获取物料信息list
        /// </summary>
        /// <param name="pFNumbers"></param>
        /// <returns></returns>
        IList GetMTLListByFNumbers(List<string> pFNumbers);
        /// <summary>
        /// 根据物料编码获取图纸信息
        /// </summary>
        /// <param name="pFNumber"></param>
        /// <returns></returns>
        DrawingInfo GetDrawingInfoByFNumber(string pFNumber);
        /// <summary>
        /// 根据物料编码获取物料信息
        /// </summary>
        /// <param name="pFNumber"></param>
        /// <returns></returns>
        MaterialInfo GetMaterialInfoByFNumber(string pFNumber);
        /// <summary>
        /// 根据条码获取操作日志信息
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <returns></returns>
        OperationInfo GetOperationInfoByBarcode(string pBarcode);
        /// <summary>
        /// 获取日志
        /// </summary>
        /// <param name="pBarcode"></param>
        /// <param name="pFBillNo"></param>
        /// <param name="pOperator"></param>
        /// <param name="pFrom"></param>
        /// <param name="pTo"></param>
        /// <returns></returns>
        DataTable GetOperations(string pBarcode, string pFBillNo, string pOperator, DateTime pFrom, DateTime pTo);
        /// <summary>
        /// 写入操作日志
        /// </summary>
        /// <param name="pOperation"></param>
        void Log_Operation(OperationInfo pOperation);
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        string EncryptData(string pPassword);
        /// <summary>
        /// 上传图纸
        /// </summary>
        /// <param name="pDrawingInf"></param>
        void UpLoadDrawing(DrawingInfo pDrawingInf);
        /// <summary>
        /// 更新图纸
        /// </summary>
        /// <param name="pDrawingInf"></param>
        void UpdateDrawing(DrawingInfo pDrawingInf);
        /// <summary>
        /// Merge Drawing
        /// </summary>
        /// <param name="pDrawingInf"></param>
        void MergeDrawing(DrawingInfo pDrawingInf);
        /// <summary>
        /// Merge MTLDrawing
        /// </summary>
        /// <param name="pMTLDrawingInf"></param>
        void MergeMTLDrawing(MTLDrawingInfo pMTLDrawingInf);
        /// <summary>
        /// 检查Drawing文件名是否存在
        /// </summary>
        /// <param name="pFileName"></param>
        /// <returns></returns>
        bool Check_DrawingFileName(string pSourcePath);
        /// <summary>
        /// 根据文件名获取Drawing Context
        /// </summary>
        /// <param name="pFileName"></param>
        /// <returns></returns>
        DrawingInfo DownLoadDrawing(string pBarcode);
        /// <summary>
        /// 删除图纸
        /// </summary>
        /// <param name="pSourcePath"></param>
        void DeleteDrawing(string pSourcePath);
        /// <summary>
        /// 修改图纸锁定状态
        /// </summary>
        /// <param name="pSourcePath"></param>
        /// <param name="pStatus"></param>
        void LockDrawing(string pSourcePath, bool pStatus);
        /// <summary>
        /// 更新模板
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pContext"></param>
        void MergeTemplate(string pFileName, byte[] pContext);
        /// <summary>
        /// 获取模板信息
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        Template_DrawingInfo GetTemplateInfoByName(string pName);

        DataTable GetDrawing();
    }
}