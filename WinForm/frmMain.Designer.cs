namespace CBSys.WinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMail = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFile_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting_Rigths = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_batchImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTool_RLImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTool_DownLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_Upload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTool_Manager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp_GetHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tt1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bnTop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnTop_lblBarcode = new System.Windows.Forms.ToolStripLabel();
            this.bnTop_txtBarcode = new System.Windows.Forms.ToolStripTextBox();
            this.bnTop_tss = new System.Windows.Forms.ToolStripSeparator();
            this.bnTop_btnSearch = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnOpen = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnDownLoad = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnBatDownLoad = new System.Windows.Forms.ToolStripButton();
            this.msMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTop)).BeginInit();
            this.bnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMail
            // 
            this.msMail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSetting,
            this.tsmiTool,
            this.tsmiHelp});
            this.msMail.Location = new System.Drawing.Point(0, 0);
            this.msMail.Name = "msMail";
            this.msMail.Size = new System.Drawing.Size(814, 25);
            this.msMail.TabIndex = 4;
            this.msMail.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile_New,
            this.tssFile1,
            this.tsmiFile_LogOut,
            this.tsmiFile_Exit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiFile_New
            // 
            this.tsmiFile_New.Enabled = false;
            this.tsmiFile_New.Name = "tsmiFile_New";
            this.tsmiFile_New.Size = new System.Drawing.Size(155, 22);
            this.tsmiFile_New.Text = "新建图纸(&N)";
            // 
            // tssFile1
            // 
            this.tssFile1.Name = "tssFile1";
            this.tssFile1.Size = new System.Drawing.Size(152, 6);
            // 
            // tsmiFile_LogOut
            // 
            this.tsmiFile_LogOut.Name = "tsmiFile_LogOut";
            this.tsmiFile_LogOut.Size = new System.Drawing.Size(155, 22);
            this.tsmiFile_LogOut.Text = "注销(Log&Out))";
            this.tsmiFile_LogOut.ToolTipText = "注销当前登陆用户并返回登陆窗口";
            this.tsmiFile_LogOut.Click += new System.EventHandler(this.tsmiFile_LogOut_Click);
            // 
            // tsmiFile_Exit
            // 
            this.tsmiFile_Exit.Name = "tsmiFile_Exit";
            this.tsmiFile_Exit.Size = new System.Drawing.Size(155, 22);
            this.tsmiFile_Exit.Text = "退出(&Exit)";
            this.tsmiFile_Exit.ToolTipText = "关闭所有窗口并退出程序";
            this.tsmiFile_Exit.Click += new System.EventHandler(this.tsmiFile_Exit_Click);
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetting_Rigths,
            this.tsmiSetting_tss1});
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(59, 21);
            this.tsmiSetting.Text = "配置(&S)";
            // 
            // tsmiSetting_Rigths
            // 
            this.tsmiSetting_Rigths.Enabled = false;
            this.tsmiSetting_Rigths.Name = "tsmiSetting_Rigths";
            this.tsmiSetting_Rigths.Size = new System.Drawing.Size(140, 22);
            this.tsmiSetting_Rigths.Text = "权限分配(&R)";
            this.tsmiSetting_Rigths.ToolTipText = "分配图纸管理权限(Admin)";
            this.tsmiSetting_Rigths.Click += new System.EventHandler(this.tsmiSetting_Rigths_Click);
            // 
            // tsmiSetting_tss1
            // 
            this.tsmiSetting_tss1.Name = "tsmiSetting_tss1";
            this.tsmiSetting_tss1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiTool
            // 
            this.tsmiTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTool_Import,
            this.tsmiTool_batchImport,
            this.tsmiTool_tss1,
            this.tsmiTool_RLImport,
            this.tsmiTool_tss2,
            this.tsmiTool_DownLoad,
            this.tsmiTool_Upload,
            this.tsmiTool_tss3,
            this.tsmiTool_Manager});
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(59, 21);
            this.tsmiTool.Text = "工具(&T)";
            // 
            // tsmiTool_Import
            // 
            this.tsmiTool_Import.Enabled = false;
            this.tsmiTool_Import.Name = "tsmiTool_Import";
            this.tsmiTool_Import.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_Import.Text = "上传图纸(&I)";
            this.tsmiTool_Import.ToolTipText = "上传单个图纸到数据库中";
            this.tsmiTool_Import.Click += new System.EventHandler(this.tsmiTool_Import_Click);
            // 
            // tsmiTool_batchImport
            // 
            this.tsmiTool_batchImport.Enabled = false;
            this.tsmiTool_batchImport.Name = "tsmiTool_batchImport";
            this.tsmiTool_batchImport.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_batchImport.Text = "批量上传图纸(&B)";
            this.tsmiTool_batchImport.ToolTipText = "批量上传图纸到数据库中";
            this.tsmiTool_batchImport.Click += new System.EventHandler(this.tsmiTool_batchImport_Click);
            // 
            // tsmiTool_tss1
            // 
            this.tsmiTool_tss1.Name = "tsmiTool_tss1";
            this.tsmiTool_tss1.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiTool_RLImport
            // 
            this.tsmiTool_RLImport.Enabled = false;
            this.tsmiTool_RLImport.Name = "tsmiTool_RLImport";
            this.tsmiTool_RLImport.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_RLImport.Text = "上传图纸关联(&R)";
            this.tsmiTool_RLImport.ToolTipText = "根据模板上传图纸对应关系";
            this.tsmiTool_RLImport.Click += new System.EventHandler(this.smiTool_RLImport_Click);
            // 
            // tsmiTool_tss2
            // 
            this.tsmiTool_tss2.Name = "tsmiTool_tss2";
            this.tsmiTool_tss2.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiTool_DownLoad
            // 
            this.tsmiTool_DownLoad.Name = "tsmiTool_DownLoad";
            this.tsmiTool_DownLoad.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_DownLoad.Text = "下载导入模板(&D)";
            this.tsmiTool_DownLoad.ToolTipText = "下载图纸关联模板到本地";
            this.tsmiTool_DownLoad.Click += new System.EventHandler(this.tsmiTool_DownLoad_Click);
            // 
            // tsmiTool_Upload
            // 
            this.tsmiTool_Upload.Enabled = false;
            this.tsmiTool_Upload.Name = "tsmiTool_Upload";
            this.tsmiTool_Upload.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_Upload.Text = "上传导入模板(&U)";
            this.tsmiTool_Upload.ToolTipText = "更新关联关系导入模板(Admin)";
            this.tsmiTool_Upload.Click += new System.EventHandler(this.tsmiTool_Upload_Click);
            // 
            // tsmiTool_tss3
            // 
            this.tsmiTool_tss3.Name = "tsmiTool_tss3";
            this.tsmiTool_tss3.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiTool_Manager
            // 
            this.tsmiTool_Manager.Enabled = false;
            this.tsmiTool_Manager.Name = "tsmiTool_Manager";
            this.tsmiTool_Manager.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_Manager.Text = "图纸管理(&M)";
            this.tsmiTool_Manager.ToolTipText = "需要图纸管理权限";
            this.tsmiTool_Manager.Click += new System.EventHandler(this.tsmiTool_Manager_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp_GetHelp});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiHelp_GetHelp
            // 
            this.tsmiHelp_GetHelp.Enabled = false;
            this.tsmiHelp_GetHelp.Name = "tsmiHelp_GetHelp";
            this.tsmiHelp_GetHelp.Size = new System.Drawing.Size(124, 22);
            this.tsmiHelp_GetHelp.Text = "获取帮助";
            // 
            // tt1
            // 
            this.tt1.IsBalloon = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(6, 52);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(801, 599);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv1_RowStateChanged);
            // 
            // bnTop
            // 
            this.bnTop.AddNewItem = null;
            this.bnTop.CountItem = null;
            this.bnTop.DeleteItem = null;
            this.bnTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnTop_lblBarcode,
            this.bnTop_txtBarcode,
            this.bnTop_tss,
            this.bnTop_btnSearch,
            this.bnTop_btnOpen,
            this.bnTop_btnDownLoad,
            this.bnTop_btnBatDownLoad});
            this.bnTop.Location = new System.Drawing.Point(0, 25);
            this.bnTop.MoveFirstItem = null;
            this.bnTop.MoveLastItem = null;
            this.bnTop.MoveNextItem = null;
            this.bnTop.MovePreviousItem = null;
            this.bnTop.Name = "bnTop";
            this.bnTop.PositionItem = null;
            this.bnTop.Size = new System.Drawing.Size(814, 25);
            this.bnTop.TabIndex = 6;
            this.bnTop.Text = "bnTop";
            this.bnTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bnTop_ItemClicked);
            // 
            // bnTop_lblBarcode
            // 
            this.bnTop_lblBarcode.Name = "bnTop_lblBarcode";
            this.bnTop_lblBarcode.Size = new System.Drawing.Size(44, 22);
            this.bnTop_lblBarcode.Text = "图纸：";
            // 
            // bnTop_txtBarcode
            // 
            this.bnTop_txtBarcode.Name = "bnTop_txtBarcode";
            this.bnTop_txtBarcode.Size = new System.Drawing.Size(300, 25);
            // 
            // bnTop_tss
            // 
            this.bnTop_tss.Name = "bnTop_tss";
            this.bnTop_tss.Size = new System.Drawing.Size(6, 25);
            // 
            // bnTop_btnSearch
            // 
            this.bnTop_btnSearch.Image = global::CBSys.WinForm.Properties.Resources.zoom;
            this.bnTop_btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnSearch.Name = "bnTop_btnSearch";
            this.bnTop_btnSearch.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnSearch.Tag = "1";
            this.bnTop_btnSearch.Text = "查询";
            // 
            // bnTop_btnOpen
            // 
            this.bnTop_btnOpen.Image = global::CBSys.WinForm.Properties.Resources.accept;
            this.bnTop_btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnOpen.Name = "bnTop_btnOpen";
            this.bnTop_btnOpen.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnOpen.Tag = "2";
            this.bnTop_btnOpen.Text = "打开";
            // 
            // bnTop_btnDownLoad
            // 
            this.bnTop_btnDownLoad.Image = global::CBSys.WinForm.Properties.Resources.table;
            this.bnTop_btnDownLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnDownLoad.Name = "bnTop_btnDownLoad";
            this.bnTop_btnDownLoad.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnDownLoad.Tag = "3";
            this.bnTop_btnDownLoad.Text = "下载";
            // 
            // bnTop_btnBatDownLoad
            // 
            this.bnTop_btnBatDownLoad.Image = global::CBSys.WinForm.Properties.Resources.table_multiple;
            this.bnTop_btnBatDownLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnBatDownLoad.Name = "bnTop_btnBatDownLoad";
            this.bnTop_btnBatDownLoad.Size = new System.Drawing.Size(76, 22);
            this.bnTop_btnBatDownLoad.Tag = "4";
            this.bnTop_btnBatDownLoad.Text = "批量下载";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 662);
            this.Controls.Add(this.bnTop);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.msMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMail;
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMail.ResumeLayout(false);
            this.msMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTop)).EndInit();
            this.bnTop.ResumeLayout(false);
            this.bnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMail;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile_New;
        private System.Windows.Forms.ToolStripSeparator tssFile1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile_LogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_Import;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_batchImport;
        private System.Windows.Forms.ToolStripSeparator tsmiTool_tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_DownLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_Upload;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp_GetHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripSeparator tsmiSetting_tss1;
        private System.Windows.Forms.ToolTip tt1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_RLImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_Manager;
        private System.Windows.Forms.ToolStripSeparator tsmiTool_tss2;
        private System.Windows.Forms.ToolStripSeparator tsmiTool_tss3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting_Rigths;
        private System.Windows.Forms.BindingNavigator bnTop;
        private System.Windows.Forms.ToolStripLabel bnTop_lblBarcode;
        private System.Windows.Forms.ToolStripTextBox bnTop_txtBarcode;
        private System.Windows.Forms.ToolStripSeparator bnTop_tss;
        private System.Windows.Forms.ToolStripButton bnTop_btnSearch;
        private System.Windows.Forms.ToolStripButton bnTop_btnOpen;
        private System.Windows.Forms.ToolStripButton bnTop_btnDownLoad;
        private System.Windows.Forms.ToolStripButton bnTop_btnBatDownLoad;
    }
}