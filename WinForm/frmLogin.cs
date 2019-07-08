using System;
using System.Windows.Forms;
using System.Configuration;
using CBSys.WinForm.Model;

namespace CBSys.WinForm
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class frmLogin : Form
    {
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
            bool bLog;
            string strURL, strZTID, strSQL_IP, strUserName = txtUser.Text.Trim(), strPWD = txtPWD.Text.Trim();

            if (string.IsNullOrEmpty(strUserName) || string.IsNullOrEmpty(strPWD))
            {
                MessageBox.Show("用户名或密码不能为空！", "错误提示");
                return;
            }

            try
            {
                strURL = ConfigurationManager.AppSettings["URL"].ToString();
                strZTID = ConfigurationManager.AppSettings["ZTID"].ToString();
                strSQL_IP = ConfigurationManager.AppSettings["SQL_IP"].ToString();

                Kingdee.BOS.WebApi.Client.K3CloudApiClient client = new Kingdee.BOS.WebApi.Client.K3CloudApiClient(strURL);
                bLog = client.Login(strZTID, strUserName, strPWD, 2052);
                if (!bLog)
                {
                    MessageBox.Show("用户名或密码错误", "登录失败");
                    return;
                }

                //Set Static Fields
                UserSetting.DB_ConnectionString = "Data Source=" + strSQL_IP + ";Initial Catalog=WMS;User ID=sa;Password=hncb2018,;Max Pool Size=1024;";
                //UserSetting.DB_ConnectionString = "Data Source=.;Initial Catalog=WMS;User ID=sa;Password=123456;Max Pool Size=1024;";
                UserSetting.K3CloudInf = new K3CloudInfo(strURL, strZTID, strUserName, strPWD, "");

                UserSetting.UserInf = strUserName == "Administrator" ? (new UserInfo(0, "Administrator", 0)) : Unity.CommonFunc.GetUserInfoByName(strUserName);
                if (UserSetting.UserInf == null)
                {
                    MessageBox.Show("未能获取用户信息", "登录失败");
                    return;
                }
                UserSetting.DeptInf = strUserName == "Administrator" ? (new DepartmentInfo(0, "System", "系统管理员")) : Unity.CommonFunc.GetDeptmentInfoById(UserSetting.UserInf.FDeptId);
                if (UserSetting.DeptInf == null)
                {
                    MessageBox.Show("未能获取用户部门信息", "登录失败");
                    return;
                }
                UserSetting.Drawing_RInf = Unity.CommonFunc.GetDrawing_RInfo("BD_Drawing");
                if (UserSetting.Drawing_RInf == null)
                {
                    MessageBox.Show("未能获取用户权限信息", "登录失败");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录失败");
                return;
            }

            //
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

        #region Events
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
        #endregion
    }
}
