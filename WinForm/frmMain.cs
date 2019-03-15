using System;
using System.IO;
using System.Data;
using System.Timers;
using System.Diagnostics;
using System.Windows.Forms;
using CBSys.WMSDyn;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using CBSys.WMSDyn.Model;

namespace CBSys.WinForm
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class frmMain : Form
    {
        #region Const,Filed,Property&Constructor
        private const string strErr1 = "文件不存在。";
        private const string strErr2 = "物料不存在、未审核或者已被禁用。";

        /// <summary>
        /// WMSDyn接口
        /// </summary>
        private ICommon IComm;

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
            //接口
            IComm = new WMSDyn.SQL.Common();

            Text = "设计图纸 - " + UserSetting.UserInf.UserName + "  班组：" + UserSetting.DeptInf.FName;

            //只允许Administrator修改模板
            if (UserSetting.UserInf.UserName != "Administrator")
                tsmiTool_Upload.Enabled = false;

            DataTable dt = IComm.GetUserDrawing();

            if (dt == null || dt.Rows.Count == 0)
                return;

            dgv1.DataSource = dt;
        }
        #endregion

        /// <summary>
        /// 扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e != null && e.KeyChar == 13)
                btnOpen_Click(sender, e);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = IComm.GetDrawing();
        }

        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //查询向数据库图纸
            //下载到本地
            //如果本地存在文件名就覆盖。


            string strBarcode;

            strBarcode = txtBarcode.Text.Trim();
            if (strBarcode.Equals(string.Empty))
                return;

            //strPath = IComm.GetUserDrawing(strBarcode);
            //if (strPath.Contains("失败"))//用户所在班组没有此条码
            //{
            //    MessageBox.Show(strPath);
            //    return;
            //}

            DrawingInfo entry = IComm.DownLoadDrawing(strBarcode);
            if (entry == null)
                return;

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
            catch //(Exception ex)
            {

            }
            finally
            {

            }

            //打开文件
            Process proc = new Process();
            proc.StartInfo.FileName = entry.FileName;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserSetting.UserInf.UserName != "Administrator")
            {
                MessageBox.Show("只有管理员可以删除图纸。");
                return;
            }

            string strBarcode;

            strBarcode = txtBarcode.Text.Trim();
            if (strBarcode.Equals(string.Empty))
                return;

            IComm.DeleteDrawing(strBarcode);
        }

        /// <summary>
        /// 锁定图纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLock_Click(object sender, EventArgs e)
        {
            string strBarcode;

            strBarcode = txtBarcode.Text.Trim();
            if (strBarcode.Equals(string.Empty))
                return;

            IComm.LockDrawing(strBarcode, true);

            MessageBox.Show("已锁定");
        }

        /// <summary>
        /// 解锁图纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnLock_Click(object sender, EventArgs e)
        {
            string strBarcode;

            strBarcode = txtBarcode.Text.Trim();
            if (strBarcode.Equals(string.Empty))
                return;

            IComm.LockDrawing(strBarcode, false);

            MessageBox.Show("已解锁");
        }

        /// <summary>
        /// 下载图纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatDownLoad_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 单击行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)//根据用户权限填充ListBox
            {
                txtBarcode.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
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

        private void tsmiFile_New_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFile_LogOut_Click(object sender, EventArgs e)
        {
            IComm.UserLogout();
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
            IComm.UserLogout();
            Dispose();
            DialogResult = DialogResult.Abort;
        }

        private void tsmiSetting_SynUser_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSetting_User_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSetting_SynDep_Click(object sender, EventArgs e)
        {

        }

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

                DrawingInfo DrawingInf = new DrawingInfo(0, "", SourcePath, FileName, FileSuffix, FileSize, UserSetting.UserInf.UserName, DateTime.Now, false, false, "用户上传", Context);
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

                fs.Close();
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
                    entry = new DrawingInfo(0, "", SourcePath, FileName, FileSuffix, FileSize, "System", DateTime.Now, false, false, "批量导入", Context);

                    try
                    {
                        IComm.UpLoadDrawing(entry);
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


            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "选择文件";
            //ofd.Filter = "图纸(*.cut)|*.cut|所有文件(*.*)|*.*";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    SourcePath = ofd.FileName;

            //    FileInfo fi = new FileInfo(SourcePath);
            //    FileStream fs = new FileStream(SourcePath, FileMode.Open);
            //    BinaryReader br = new BinaryReader(fs);
            //    Context = br.ReadBytes(Convert.ToInt32(fs.Length));

            //    FileName = SourcePath.Substring(SourcePath.LastIndexOf("\\") + 1);
            //    FileSuffix = FileName.Substring(FileName.IndexOf(".") + 1);
            //    FileSize = fi.Length;

            //    fs.Close();
            //}

            //string filePath = string.Empty;
            //string strError = string.Empty;

            //long FileSize;
            ////string FNumber;
            //string SourcePath;
            //string FileName;
            //string FileSuffix;
            //string Description;
            //byte[] Context;
            ////WMSDyn.Model.MaterialInfo MTLInf;
            //WMSDyn.Model.DrawingInfo DrawingInf;

            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = false;
            //fileDialog.Title = "请选择Excel文件";
            //fileDialog.Filter = "Excel报表(*.xls;*.xlsx)|*.xls;*.xlsx";

            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = fileDialog.FileName;
            //}
            //if (filePath.Length <= 0) return;
            ////导入
            //object missing = Type.Missing;
            //Excel.Application myApp = new Excel.Application();
            //myApp.DisplayAlerts = false;
            //Excel.Workbook workBook = myApp.Workbooks.Open(filePath, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
            //Excel.Worksheet worksheet = workBook.Worksheets[1] as Excel.Worksheet;
            //myApp.Visible = false;

            //if (worksheet.Cells[1, 1].Text != "文件名" || worksheet.Cells[1, 2].Text != "上传路径" || worksheet.Cells[1, 3].Text != "物料编码")
            //{
            //    MessageBox.Show("导入模板格式不正确。");
            //    workBook.Close();
            //    return;
            //}

            //for (int i = 2; i <= worksheet.UsedRange.Rows.Count; i++)
            //{
            //    try
            //    {
            //        FileName = worksheet.Cells[i, 1].Text;
            //        SourcePath = worksheet.Cells[i, 2].Text + "\\" + FileName;
            //        //FNumber = worksheet.Cells[i, 3].Text;
            //        Description = worksheet.Cells[i, 4].Text;

            //        FileInfo fi = new FileInfo(SourcePath);
            //        if (!fi.Exists)
            //        {
            //            worksheet.Cells[i, 6] = strErr1;
            //            strError += strErr1;
            //            continue;
            //        }

            //        FileStream fs = new FileStream(SourcePath, FileMode.Open);
            //        BinaryReader br = new BinaryReader(fs);
            //        Context = br.ReadBytes(Convert.ToInt32(fs.Length));
            //        FileName = SourcePath.Substring(SourcePath.LastIndexOf("\\") + 1);
            //        FileSuffix = FileName.Substring(FileName.IndexOf(".") + 1);
            //        FileSize = fi.Length;
            //        fs.Close();

            //        //MTLInf = IComm.GetMaterialInfoByFNumber(FNumber);
            //        //if (MTLInf == null)
            //        //{
            //        //    worksheet.Cells[i, 6] = strErr2;
            //        //    strError += strErr2;
            //        //    continue;
            //        //}

            //        DrawingInf = new WMSDyn.Model.DrawingInfo(0, "", SourcePath, FileName, FileSuffix, FileSize, WMSDyn.Model.UserSetting.UserInf.UserName, DateTime.Now, false, false, string.Empty, Context);

            //        ////文件已存在
            //        //if (IComm.Check_DrawingFileName(DrawingInf.SourcePath))
            //        //{
            //        //    IComm.UpdateDrawing(DrawingInf);
            //        //    worksheet.Cells[i, 6] = "更新成功";
            //        //    continue;
            //        //}

            //        //IComm.UpLoadDrawing(DrawingInf);

            //        IComm.MergeDrawing(DrawingInf);
            //    }
            //    catch (Exception ex)
            //    {
            //        worksheet.Cells[i, 6] = ex.Message;
            //        strError += ex.Message;
            //        continue;
            //    }

            //    worksheet.Cells[i, 6] = "导入成功";
            //}
            //if (strError != "")
            //{
            //    MessageBox.Show("有些信息导入出错，请查看最后一列的错误提示！");
            //}
            //else
            //{
            //    MessageBox.Show("全部数据已经成功导入！");
            //}

            //myApp.Visible = true;
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
            //MTLDrawingInfo MTLDrawingInf;

            for (int i = 3; i <= worksheet.UsedRange.Rows.Count; i++)
            {
                try
                {
                    Barcode = worksheet.Cells[i, 1] == null ? "" : worksheet.Cells[i, 1].Text;//条码
                    MTLNumber = worksheet.Cells[i, 2] == null ? "" : worksheet.Cells[i, 2].Text;//物料编码

                    CatetoryId = worksheet.Cells[i, 2] == null ? 0 : int.Parse(worksheet.Cells[i, 3].Text);//版型类别
                    bFlag = worksheet.Cells[i, 4].Text == "" ? false : bool.Parse(worksheet.Cells[i, 4].Text);//通用
                    F_PAEZ_TRADE = worksheet.Cells[i, 5].Text;//商品名
                    F_PAEZ_CARSERIES = worksheet.Cells[i, 6].Text;//车系
                    F_PAEZ_CARTYPE = worksheet.Cells[i, 7].Text;//车型
                    SourcePath = worksheet.Cells[i, 8].Text + "\\" + worksheet.Cells[i, 9].Text;//完整原路径

                    Description = worksheet.Cells[i, 10] == null ? "" : worksheet.Cells[i, 10].Text;//描述

                    //MTLDrawingInf = new MTLDrawingInfo(CatetoryId, SourcePath, Barcode, 0, MTLNumber, F_PAEZ_TRADE, F_PAEZ_CARSERIES, F_PAEZ_CARTYPE, bFlag);

                    if (!IComm.Check_DrawingFileName(SourcePath))//文件检验
                    {
                        worksheet.Cells[i, 12] = strErr1;
                        strError += strErr1;
                        continue;
                    }

                    //更新图纸关联
                    IComm.MergeMTLDrawing(new MTLDrawingInfo(CatetoryId, SourcePath, Barcode, 0, MTLNumber, F_PAEZ_TRADE, F_PAEZ_CARSERIES, F_PAEZ_CARTYPE, bFlag));
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
            WMSDyn.Model.Template_DrawingInfo entry = IComm.GetTemplateInfoByName("TP_TL_MTLDrawing.xls");

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
            }

            MessageBox.Show("模板下载成功。");
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

                IComm.MergeTemplate(fileName, byteDate);
                MessageBox.Show("模板上传成功。");
            }
        }

        /// <summary>
        /// 帮助信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiHelp_GetHelp_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}