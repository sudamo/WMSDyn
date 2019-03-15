using System;
using System.IO;
using CBSys.WMSDyn.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBSys.WinForm
{
    public partial class frmUpLoadDrawing : Form
    {
        private long FileSize;
        private string SourcePath;
        private string FileName;
        private string FileSuffix;
        private byte[] Context;
        private WMSDyn.ICommon IComm;

        public frmUpLoadDrawing()
        {
            InitializeComponent();
            IComm = new WMSDyn.SQL.Common();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择文件";
            ofd.Filter = "图纸(*.cut)|*.cut|所有文件(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = SourcePath = ofd.FileName;

                FileInfo fi = new FileInfo(SourcePath);
                FileStream fs = new FileStream(SourcePath, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                Context = br.ReadBytes(Convert.ToInt32(fs.Length));
                
                FileName = SourcePath.Substring(SourcePath.LastIndexOf("\\") + 1);
                FileSuffix = FileName.Substring(FileName.IndexOf(".") + 1);
                FileSize = fi.Length;

                fs.Close();
                btnOK.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || string.IsNullOrEmpty(txtMTL.Text.Trim()))
                return;

            string strMTLNumber = txtMTL.Text.Trim();

            MaterialInfo MTLInf = IComm.GetMaterialInfoByFNumber(strMTLNumber);
            if (MTLInf == null)
            {
                MessageBox.Show("物料不存在、未审核或者已被禁用。");
                return;
            }

            DrawingInfo DrawingInf = new DrawingInfo(MTLInf.FMaterialId, MTLInf.FNumber, SourcePath, FileName, FileSuffix, FileSize, UserSetting.UserInf.UserName, DateTime.Now, false, false, string.Empty, Context);

            if (IComm.Check_DrawingFileName(SourcePath))
            {
                IComm.UpdateDrawing(DrawingInf);
                MessageBox.Show("更新成功。");
            }
            else
            {
                IComm.UpLoadDrawing(DrawingInf);
                MessageBox.Show("上传成功。");
            }

            Close();
        }
    }
}
