using System;
using System.Data;
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
        public Common() { }
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
        /// 根据物料编码获取物料信息
        /// </summary>
        /// <param name="pFNumber">物料编码</param>
        /// <returns></returns>
        public MaterialInfo GetMaterialInfoByFNumber(string pFNumber)
        {
            return CommonFunction.GetMaterialInfoByFNumber(pFNumber);
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
        public DrawingInfo GetDrawing(string pSourcePath)
        {
            return CommonFunction.GetDrawing(pSourcePath);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSourcePathList">SourcePathList</param>
        /// <returns></returns>
        public List<DrawingInfo> GetDrawing(List<string> pSourcePathList)
        {
            return CommonFunction.GetDrawing(pSourcePathList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pFlag"></param>
        /// <returns></returns>
        public DataTable GetDrawing(string pFileName, bool? pFlag)
        {
            return CommonFunction.GetDrawing(pFileName, pFlag);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pGeneral"></param>
        /// <param name="pArt"></param>
        /// <param name="pCust"></param>
        /// <returns></returns>
        public DataTable GetDrawing(string pFileName, bool pGeneral, bool pArt, bool pCust)
        {
            return CommonFunction.GetDrawing(pFileName, pGeneral, pArt, pCust);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Drawing_RInfo GetDrawing_RInfo()
        {
            return CommonFunction.GetDrawing_RInfo("BD_Drawing");
        }

        /// <summary>
        /// 
        /// </summary>
        public void ModifyDrawing_RInfo()
        {
            CommonFunction.ModifyDrawing_RInfo();
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
        /// <param name="pProcessName"></param>
        public void KillPro(string pProcessName)
        {
            CommonFunction.KillPro(pProcessName);
        }
    }
}
