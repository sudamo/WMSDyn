using System;
using System.Windows.Forms;
using System.Configuration;
using CBSys.WMSDyn.Model;

namespace CBSys.WinForm
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class frmLogin : Form
    {
        private Configuration _Config;
        private Kingdee.BOS.WebApi.Client.K3CloudApiClient _Client;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = txtUser.Text.Trim();//登陆用户名
            string strPWD = txtPWD.Text.Trim();//登陆用户密码

            if (string.IsNullOrEmpty(strUserName) || string.IsNullOrEmpty(strPWD))
            {
                MessageBox.Show("用户名或密码不能为空！", "错误提示");
                return;
            }

            bool bLog = false;
            string strURL, strZTID, strConnectionString;


            _Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            strURL = _Config.AppSettings.Settings["C_URL"].Value;
            strZTID = _Config.AppSettings.Settings["C_ZTID"].Value;
            strConnectionString = _Config.AppSettings.Settings["ConnectionString"].Value;

            _Client = new Kingdee.BOS.WebApi.Client.K3CloudApiClient(strURL);

            try
            {
                bLog = _Client.Login(strZTID, strUserName, strPWD, 2052);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "网络链接错误");
                return;
            }
            if (!bLog)
            {
                MessageBox.Show("用户名或密码错误", "登录失败");
                return;
            }
            WMSDyn.ICommon IComm = new WMSDyn.SQL.Common();
            //Set Static Fields
            UserSetting.K3CloudInf = new K3CloudInfo(strURL, strZTID, strUserName, strPWD, "");
            UserSetting.UserInf = strUserName == "Administrator" ? (new UserInfo(0, "Administrator", 0)) : IComm.GetUserInfoByName(strUserName);
            UserSetting.DeptInf = strUserName == "Administrator" ? (new DepartmentInfo(0, "System", "系统管理员")) : IComm.GetDeptmentInfoById(UserSetting.UserInf.FDeptId);
            UserSetting.DB_ConnectionString = strConnectionString;

            if (UserSetting.UserInf == null || UserSetting.DeptInf == null)
            {
                MessageBox.Show("找不到用户部门信息。");
                return;
            }

            frmMain frm = new frmMain();
            try
            {
                Visible = false;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (frm.DialogResult == DialogResult.None)//注销
                {
                    Visible = true;
                }
                else//退出
                {
                    Close();
                    Application.Exit();
                }
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="pUserName"></param>
        ///// <returns></returns>
        //private UserInfo GetUserInfoByName(string pUserName)
        //{
        //    UserInfo entry = new UserInfo();
        //    bool bLogin = _Client.Login(UserSetting.K3CloudInf.C_ZTID, pUserName, txtPWD.Text.Trim(), 2052);
        //    string strJson = "{\"FormId\":\"BD_Empinfo\",\"FieldKeys\":\"FNAME,FNumber,FPERSONID,FSTAFFID,FPOSTDEPT\",\"FilterString\":\"FNAME = '" + pUserName + "'\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
        //    if (bLogin)
        //    {
        //        try
        //        {
        //            List<List<object>> list = _Client.ExecuteBillQuery(strJson);
        //            if (list.Count > 0)
        //            {
        //                entry.UserName = pUserName;
        //                entry.FNumber = list[0][1].ToString();
        //                entry.PersonId = list[0][2] == null ? 0 : int.Parse(list[0][2].ToString());
        //                entry.StaffId = list[0][3] == null ? 0 : int.Parse(list[0][3].ToString());
        //                entry.FDeptId = list[0][4] == null ? 0 : int.Parse(list[0][4].ToString());
        //            }
        //            else
        //                return null;
        //        }
        //        catch //(Exception ex)
        //        {
        //            return null;
        //        }
        //    }
        //    return entry;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="pDeptId"></param>
        ///// <returns></returns>
        //private DepartmentInfo GetDeptmentInfoById(int? pDeptId)
        //{
        //    if (pDeptId == null) return null;
        //    DepartmentInfo entry = new DepartmentInfo();
        //    bool bLogin = _Client.Login(UserSetting.K3CloudInf.C_ZTID, txtUser.Text.Trim(), txtPWD.Text.Trim(), 2052);
        //    string strJson = "{\"FormId\":\"BD_Department\",\"FieldKeys\":\"FDeptId,FNAME,FNUMBER\",\"FilterString\":\"FDeptId = " + pDeptId.ToString() + "\",\"OrderString\":\"\",\"TopRowCount\":\"0\",\"StartRow\":\"0\",\"Limit\":\"0\"}";
        //    if (bLogin)
        //    {
        //        try
        //        {
        //            List<List<object>> list = _Client.ExecuteBillQuery(strJson);
        //            if (list.Count > 0)
        //            {
        //                entry.FDeptId = pDeptId;
        //                entry.FName = list[0][1].ToString();
        //                entry.FNumber = list[0][2].ToString();
        //            }
        //            else
        //                return null;
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }
        //    return entry;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPWD.SelectAll();
                txtPWD.Focus();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lklK3Cloud_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmK3Setting frm = new frmK3Setting();
            frm.ShowDialog();
        }
    }
}
