using System;
using System.IO;
using System.Windows.Forms;
using CBSys.WinForm.Model;
using CBSys.WinForm.Unity;

namespace CBSys.WinForm
{
    public partial class frmManage_Edit : Form
    {
        private int _PID;
        private string _FileName;
        private string _SourcePath;
        private DrawingInfo _Entry;

        public frmManage_Edit(int pPID, string pFileName, string pSourcePath)
        {
            InitializeComponent();

            _PID = pPID;
            _FileName = pFileName;
            _SourcePath = pSourcePath;
        }

        private void frmManage_Edit_Load(object sender, EventArgs e)
        {
            txtFileName.Text = _FileName;
            txtSourcePath.Text = _SourcePath;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            long FileSize;
            byte[] Context;
            string SourcePath, FileName, FileSuffix;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择文件";
            ofd.Filter = "图纸(*.cut)|*.cut|所有文件(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SourcePath = ofd.FileName;

                FileStream fs = new FileStream(SourcePath, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                Context = br.ReadBytes(Convert.ToInt32(fs.Length));

                FileName = SourcePath.Substring(SourcePath.LastIndexOf("\\") + 1);
                FileSuffix = FileName.Substring(FileName.IndexOf(".") + 1);
                FileSize = fs.Length;
                fs.Close();

                _Entry = new DrawingInfo(_PID, 0, "", SourcePath, FileName, FileSuffix, FileSize, UserSetting.UserInf.UserName, DateTime.Now, false, false, "修改-图纸替换", Context);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim().Equals(string.Empty) || txtSourcePath.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("还有信息未填写。");
                return;
            }

            if (_Entry == null)
                CommonFunc.UpdateDrawing(_PID, txtFileName.Text.Trim(), txtSourcePath.Text.Trim());
            else
                CommonFunc.UpdateDrawing(_Entry);

            MessageBox.Show("更新成功。");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
