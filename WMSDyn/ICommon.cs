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
        /// 根据物料编码获取物料信息
        /// </summary>
        /// <param name="pFNumber"></param>
        /// <returns></returns>
        MaterialInfo GetMaterialInfoByFNumber(string pFNumber);
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
        /// 根据源路径获取图纸信息
        /// </summary>
        /// <param name="pFileName"></param>
        /// <returns></returns>
        DrawingInfo GetDrawing(string pSourcePath);
        /// <summary>
        /// 根据源路径获取图纸信息
        /// </summary>
        /// <param name="pList">SourcePathList</param>
        /// <returns></returns>
        List<DrawingInfo> GetDrawing(List<string> pSourcePathList);
        /// <summary>
        /// 根据文件名获取图纸信息
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pFlag"></param>
        /// <returns></returns>
        DataTable GetDrawing(string pFileName, bool? pFlag);
        /// <summary>
        /// 根据文件名获取图纸信息
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pGeneral"></param>
        /// <param name="pArt"></param>
        /// <param name="pCust"></param>
        /// <returns></returns>
        DataTable GetDrawing(string pFileName, bool pGeneral, bool pArt, bool pCust);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Drawing_RInfo GetDrawing_RInfo();
        /// <summary>
        /// 
        /// </summary>
        void ModifyDrawing_RInfo();
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
        /// <summary>
        /// 关闭指定进程
        /// </summary>
        /// <param name="pProcessName"></param>
        void KillPro(string pProcessName);
    }
}