using System;
using System.Windows.Forms;
using System.Configuration;

namespace CBSys.WinForm
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmK3Setting : Form
    {
        private Configuration _Config;
        /// <summary>
        /// 
        /// </summary>
        public frmK3Setting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmK3Setting_Load(object sender, EventArgs e)
        {
            ////获取Configuration对象
            //Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ////根据Key读取<add>元素的Value
            //string name = config.AppSettings.Settings["name"].Value;
            ////写入<add>元素的Value
            //config.AppSettings.Settings["name"].Value = "test";
            ////增加<add>元素
            //config.AppSettings.Settings.Add("url", "test");
            ////删除<add>元素
            //config.AppSettings.Settings.Remove("name");
            ////一定要记得保存，写不带参数的config.Save()也可以
            //config.Save(ConfigurationSaveMode.Modified);
            ////刷新，否则程序读取的还是之前的值（可能已装入内存）
            //System.Configuration.ConfigurationManager.RefreshSection("appSettings");

            _Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            txtUrl.Text= _Config.AppSettings.Settings["C_URL"].Value;
            txtZTID.Text = _Config.AppSettings.Settings["C_ZTID"].Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Config.AppSettings.Settings["C_URL"].Value = txtUrl.Text;
            _Config.AppSettings.Settings["C_ZTID"].Value = txtZTID.Text;
            _Config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
