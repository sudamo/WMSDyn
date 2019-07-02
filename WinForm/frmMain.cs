using System;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using CBSys.WinForm.Model;
using CBSys.WinForm.Unity;

namespace CBSys.WinForm
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class frmMain : Form
    {
        #region Const,Filed,Property&Constructor

        /// <summary>
        /// 
        /// </summary>
        private DataTable _DataSource;

        /// <summary>
        /// 构造函数
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = "设计图纸 - " + UserSetting.UserInf.UserName + "  班组：" + UserSetting.DeptInf.FName;

            //权限控制
            if (UserSetting.UserInf.UserName != "Administrator" && UserSetting.UserInf.UserName != "马强强")
            {
                //if(UserSetting.Drawing_RInf.M_Users.Contains(UserSetting.UserInf.UserName))//Admin
                //    tsmiSetting_Rigths.Enabled = true;

                //
                if (UserSetting.Drawing_RInf.U_Users.Contains(UserSetting.UserInf.UserName))
                {
                    tsmiTool_Import.Enabled = true;
                    tsmiTool_batchImport.Enabled = true;
                }
                if (UserSetting.Drawing_RInf.D_Users.Contains(UserSetting.UserInf.UserName))
                {
                    //btnDownLoad.Enabled = true;//Enabled
                    bnTop_btnBatDownLoad.Enabled = true;
                }
                //
                if (UserSetting.Drawing_RInf.U_Users2.Contains(UserSetting.UserInf.UserName))
                    tsmiTool_RLImport.Enabled = true;
                //if (UserSetting.Drawing_RInf.D_Users2.Contains(UserSetting.UserInf.UserName))//None
                //
                //if (UserSetting.Drawing_RInf.U_Users3.Contains(UserSetting.UserInf.UserName))//Admin
                //    tsmiTool_Upload.Enabled = true;
                //if (UserSetting.Drawing_RInf.D_Users3.Contains(UserSetting.UserInf.UserName))//Enabled
                //    tsmiTool_DownLoad.Enabled = true;
                //
                if (UserSetting.Drawing_RInf.Managers.Contains(UserSetting.UserInf.UserName))
                    tsmiTool_Manager.Enabled = true;
            }
            else
            {
                tsmiSetting_Rigths.Enabled = true;

                tsmiTool_Import.Enabled = true;
                tsmiTool_batchImport.Enabled = true;
                tsmiTool_RLImport.Enabled = true;
                //tsmiTool_DownLoad.Enabled = true;//Enabled
                tsmiTool_Upload.Enabled = true;

                tsmiTool_Manager.Enabled = true;

                bnTop_btnDownLoad.Enabled = true;
                bnTop_btnBatDownLoad.Enabled = true;
            }

            ToolStripCheckBox chb = new ToolStripCheckBox();
            ((CheckBox)(chb.Control)).Checked = true;
            ((CheckBox)(chb.Control)).Text = "通用";
            bnTop.Items.Add(chb);

            ToolStripCheckBox chb1 = new ToolStripCheckBox();
            ((CheckBox)(chb1.Control)).Checked = true;
            ((CheckBox)(chb1.Control)).Text = "艺术";
            bnTop.Items.Add(chb1);

            ToolStripCheckBox chb2 = new ToolStripCheckBox();
            ((CheckBox)(chb2.Control)).Checked = true;
            ((CheckBox)(chb2.Control)).Text = "定制";
            bnTop.Items.Add(chb2);

            //重新排列Items
            List<ToolStripItem> list = new List<ToolStripItem>();
            list.Add(bnTop.Items[0]);
            list.Add(bnTop.Items[1]);
            list.Add(bnTop.Items[7]);
            list.Add(bnTop.Items[8]);
            list.Add(bnTop.Items[9]);
            list.Add(bnTop.Items[2]);
            list.Add(bnTop.Items[3]);
            list.Add(bnTop.Items[4]);
            list.Add(bnTop.Items[5]);
            list.Add(bnTop.Items[6]);

            bnTop.Items.Clear();
            foreach (ToolStripItem item in list)
            {
                bnTop.Items.Add(item);
            }
        }
        #endregion

        /// <summary>
        /// 单击行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1 != null && dgv1.Rows.Count > 0)//根据用户权限填充ListBox
            {
                bnTop_txtBarcode.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        /// <summary>
        /// 行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        #region 菜单

        #region File

        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFile_LogOut_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFile_Exit_Click(object sender, EventArgs e)
        {
            //IComm.UserLogout();
            Dispose();
            DialogResult = DialogResult.Abort;
        }
        #endregion

        #region Setting

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSetting_Rigths_Click(object sender, EventArgs e)
        {
            frmRight frm = new frmRight();
            frm.Show();
        }
        #endregion

        #region Tool

        /// <summary>
        /// 导入单个图纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTool_Import_Click(object sender, EventArgs e)
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

                DrawingInfo DrawingInf = new DrawingInfo(0, "", SourcePath, FileName, FileSuffix, FileSize, UserSetting.UserInf.UserName, DateTime.Now, false, false, "用户上传", Context);
                if (CommonFunc.Check_DrawingFileName(SourcePath))
                {
                    CommonFunc.UpdateDrawing(DrawingInf);
                    MessageBox.Show("更新成功。");
                }
                else
                {
                    CommonFunc.UpLoadDrawing(DrawingInf);
                    MessageBox.Show("上传成功。");
                }
            }
        }

        /// <summary>
        /// 批量上传图纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTool_batchImport_Click(object sender, EventArgs e)
        {
            long FileSize;
            byte[] Context;
            string[] arrSourcePath;
            string FileDir, FileName, FileSuffix, strError = string.Empty;
            DrawingInfo entry;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileDir = fbd.SelectedPath;
                arrSourcePath = Directory.GetFiles(FileDir, "*.cut", SearchOption.AllDirectories);

                FileStream fs;
                BinaryReader br;
                foreach (string SourcePath in arrSourcePath)
                {
                    fs = new FileStream(SourcePath, FileMode.Open);
                    br = new BinaryReader(fs);
                    Context = br.ReadBytes(Convert.ToInt32(fs.Length));
                    FileName = SourcePath.Substring(SourcePath.LastIndexOf("\\") + 1);
                    FileSuffix = FileName.Substring(FileName.IndexOf(".") + 1);
                    FileSize = fs.Length;
                    fs.Close();//?

                    entry = new DrawingInfo(0, "", SourcePath, FileName, FileSuffix, FileSize, "System", DateTime.Now, false, false, "批量导入", Context);

                    try
                    {
                        CommonFunc.UpLoadDrawing(entry);
                    }
                    catch (Exception ex)
                    {
                        strError += "|" + ex.Message;
                    }
                }
            }
            else
                return;

            if (strError != string.Empty)
            {
                MessageBox.Show("部分上传失败：" + strError);
                return;
            }
            else
            {
                MessageBox.Show("全部上传成功。");
                return;
            }
        }

        /// <summary>
        /// 上传图纸关联
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smiTool_RLImport_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty, strError = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择Excel文件";
            fileDialog.Filter = "Excel报表(*.xls;*.xlsx)|*.xls;*.xlsx";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
            }
            if (filePath.Length <= 0) return;

            //导入
            object missing = Type.Missing;
            Excel.Application myApp = new Excel.Application();
            myApp.DisplayAlerts = false;
            Excel.Workbook workBook = myApp.Workbooks.Open(filePath, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
            Excel.Worksheet worksheet = workBook.Worksheets[1] as Excel.Worksheet;
            myApp.Visible = false;

            if (worksheet.Cells[1, 1].Text != "图纸关联模板")
            {
                MessageBox.Show("请选择[图纸关联模板]。");
                workBook.Close();
                return;
            }

            bool bFlag;
            int CatetoryId;
            string Barcode, MTLNumber, F_PAEZ_TRADE, F_PAEZ_CARSERIES, F_PAEZ_CARTYPE, SourcePath, Description;

            for (int i = 3; i <= worksheet.UsedRange.Rows.Count; i++)
            {
                try
                {
                    Barcode = worksheet.Cells[i, 1] == null ? "" : worksheet.Cells[i, 1].Text;//条码
                    MTLNumber = worksheet.Cells[i, 2] == null ? "" : worksheet.Cells[i, 2].Text;//物料编码

                    CatetoryId = worksheet.Cells[i, 3] == null ? 0 : int.Parse(worksheet.Cells[i, 3].Text);//版型类别
                    bFlag = worksheet.Cells[i, 4].Text == "" ? false : bool.Parse(worksheet.Cells[i, 4].Text);//通用
                    F_PAEZ_TRADE = worksheet.Cells[i, 5].Text;//商品名
                    F_PAEZ_CARSERIES = worksheet.Cells[i, 6].Text;//车系
                    F_PAEZ_CARTYPE = worksheet.Cells[i, 7].Text;//车型
                    SourcePath = worksheet.Cells[i, 8].Text + "\\" + worksheet.Cells[i, 9].Text;//完整原路径

                    Description = worksheet.Cells[i, 10] == null ? "" : worksheet.Cells[i, 10].Text;//描述

                    if (!CommonFunc.Check_DrawingFileName(SourcePath))//文件检验
                    {
                        worksheet.Cells[i, 12] = "文件不存在。";
                        strError += "文件不存在。";
                        continue;
                    }

                    //更新图纸关联
                    CommonFunc.MergeMTLDrawing(new MTLDrawingInfo(CatetoryId, SourcePath, Barcode, 0, MTLNumber, F_PAEZ_TRADE, F_PAEZ_CARSERIES, F_PAEZ_CARTYPE, bFlag));
                }
                catch (Exception ex)
                {
                    worksheet.Cells[i, 12] = ex.Message;
                    strError += ex.Message;
                    continue;
                }

                worksheet.Cells[i, 12] = "导入成功";
            }
            if (strError != "")
            {
                MessageBox.Show("部分信息导入出错，请查看最后一列的错误提示！");
            }
            else
            {
                MessageBox.Show("全部数据已经成功导入！");
            }

            myApp.Visible = true;
        }

        /// <summary>
        /// 下载模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTool_DownLoad_Click(object sender, EventArgs e)
        {
            Template_DrawingInfo entry = CommonFunc.GetTemplateInfoByName("TP_TL_MTLDrawing.xls");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx";
            sfd.RestoreDirectory = false;
            sfd.FileName = "TP_Drawing.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter bw = new BinaryWriter(File.Open(sfd.FileName, FileMode.OpenOrCreate));
                bw.Write(entry.Context);
                bw.Close();

                MessageBox.Show("模板下载成功。");
            }
        }

        /// <summary>
        /// 上传模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTool_Upload_Click(object sender, EventArgs e)
        {
            string filePath, fileName;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "选择文件";
            fileDialog.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                FileInfo fi = new FileInfo(filePath);
                FileStream fs = new FileStream(filePath, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                byte[] byteDate = br.ReadBytes(Convert.ToInt32(fs.Length));

                fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);

                fs.Close();

                CommonFunc.MergeTemplate(fileName, byteDate);
                MessageBox.Show("模板上传成功。");
            }
        }

        /// <summary>
        /// 图纸管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTool_Manager_Click(object sender, EventArgs e)
        {
            frmManage manage = new frmManage();
            manage.ShowDialog();
        }
        #endregion

        #endregion

        private void bnTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag == null)
                return;

            switch (e.ClickedItem.Tag.ToString())
            {
                case "1":
                    Search();
                    break;
                case "2":
                    Open();
                    break;
                case "3":
                    DownLoad();
                    break;
                case "4":
                    BatchDownLoad();
                    break;
            }
        }

        private void Search()
        {
            try
            {
                 _DataSource = CommonFunc.GetDrawing(bnTop_txtBarcode.Text.Trim(), ((CheckBox)((ControlAccessibleObject)(bnTop.Items[2]).AccessibilityObject).Owner).Checked, ((CheckBox)((ControlAccessibleObject)(bnTop.Items[3]).AccessibilityObject).Owner).Checked, ((CheckBox)((ControlAccessibleObject)(bnTop.Items[4]).AccessibilityObject).Owner).Checked);

                if (_DataSource == null || _DataSource.Rows.Count == 0) return;

                dgv1.DataSource = _DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Open()
        {
            if (dgv1 == null || dgv1.Rows.Count == 0)
                return;
            if (bnTop_txtBarcode.Text.Trim().Equals(string.Empty))
                return;

            string strSourcePath = dgv1.CurrentRow.Cells[11].Value.ToString();
            if (strSourcePath.Equals(string.Empty))
                return;

            DrawingInfo entry = CommonFunc.GetDrawing(strSourcePath);
            if (entry == null)
                return;

            if (entry.Flag)
            {
                MessageBox.Show("图纸被锁定。");
                return;
            }

            //检查目录是否存在
            string strFilePath = @"C:\Drawing";
            if (!Directory.Exists(strFilePath))
            {
                Directory.CreateDirectory(strFilePath);
            }
            strFilePath += "\\" + DateTime.Now.ToString("yyyyMMdd");
            if (!Directory.Exists(strFilePath))
            {
                Directory.CreateDirectory(strFilePath);
            }

            entry.FileName = strFilePath + "\\" + entry.FileName;

            try
            {
                BinaryWriter bw = new BinaryWriter(File.Open(entry.FileName, FileMode.OpenOrCreate));
                bw.Write(entry.Context);
                bw.Close();
            }
            catch { }

            ;
            //关闭已打开的软件
            CommonFunc.KillPro("SmartCutAutoPlan");
            //打开文件
            Process proc = new Process();
            proc.StartInfo.FileName = entry.FileName;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
        private void DownLoad()
        {
            if (dgv1 == null || dgv1.Rows.Count == 0)
                return;

            string strSourcePath = dgv1.CurrentRow.Cells[11].Value.ToString();
            if (strSourcePath.Equals(string.Empty))
                return;

            DrawingInfo entry = CommonFunc.GetDrawing(strSourcePath);
            if (entry == null)
                return;

            if (!Directory.Exists(entry.SourcePath.Substring(0, entry.SourcePath.LastIndexOf('\\') + 1)))
                Directory.CreateDirectory(entry.SourcePath.Substring(0, entry.SourcePath.LastIndexOf('\\') + 1));

            BinaryWriter bw = new BinaryWriter(File.Create(entry.SourcePath));
            bw.Write(entry.Context);
            bw.Close();

            MessageBox.Show("下载完毕，文件路径：" + entry.SourcePath);
        }
        private void BatchDownLoad()
        {
            if (_DataSource == null || _DataSource.Rows.Count == 0)
                return;

            List<string> lstSourcePath = new List<string>();
            for (int i = 0; i < _DataSource.Rows.Count; i++)
            {
                if (_DataSource.Rows[i]["源路径"].ToString() != "")
                    lstSourcePath.Add(_DataSource.Rows[i]["源路径"].ToString());
            }

            if (!Directory.Exists("D:\\"))
            {
                MessageBox.Show("D盘不存在，选择默认下载路径失败。");
                return;
            }

            List<DrawingInfo> list = CommonFunc.GetDrawing(lstSourcePath);

            if (list.Count == 0)
            {
                MessageBox.Show("没有查询到对应的图纸。");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (!Directory.Exists(list[i].SourcePath.Substring(0, list[i].SourcePath.LastIndexOf('\\') + 1)))
                    Directory.CreateDirectory(list[i].SourcePath.Substring(0, list[i].SourcePath.LastIndexOf('\\') + 1));

                BinaryWriter bw = new BinaryWriter(File.Create(list[i].SourcePath));
                bw.Write(list[i].Context);
                bw.Close();
            }

            MessageBox.Show("下载完毕");
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class ToolStripCheckBox : ToolStripControlHost
    {
        public ToolStripCheckBox() : base(new CheckBox())
        {

        }
    }
}