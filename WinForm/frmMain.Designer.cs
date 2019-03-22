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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pl1 = new System.Windows.Forms.Panel();
            this.chbCust = new System.Windows.Forms.CheckBox();
            this.chbArt = new System.Windows.Forms.CheckBox();
            this.chbGeneral = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnBatDownLoad = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.msMail = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFile_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetting_Rigths = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pl1.SuspendLayout();
            this.msMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("宋体", 9F);
            this.txtBarcode.Location = new System.Drawing.Point(49, 3);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(420, 21);
            this.txtBarcode.TabIndex = 1;
            this.tt1.SetToolTip(this.txtBarcode, "扫描条码到此输入框");
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // pl1
            // 
            this.pl1.Controls.Add(this.chbCust);
            this.pl1.Controls.Add(this.chbArt);
            this.pl1.Controls.Add(this.chbGeneral);
            this.pl1.Controls.Add(this.btnSearch);
            this.pl1.Controls.Add(this.btnDownLoad);
            this.pl1.Controls.Add(this.btnBatDownLoad);
            this.pl1.Controls.Add(this.btnOpen);
            this.pl1.Controls.Add(this.lblBarcode);
            this.pl1.Controls.Add(this.txtBarcode);
            this.pl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl1.Location = new System.Drawing.Point(0, 25);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(814, 48);
            this.pl1.TabIndex = 2;
            // 
            // chbCust
            // 
            this.chbCust.AutoSize = true;
            this.chbCust.Checked = true;
            this.chbCust.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCust.Location = new System.Drawing.Point(153, 29);
            this.chbCust.Margin = new System.Windows.Forms.Padding(2);
            this.chbCust.Name = "chbCust";
            this.chbCust.Size = new System.Drawing.Size(48, 16);
            this.chbCust.TabIndex = 3;
            this.chbCust.Text = "定制";
            this.chbCust.UseVisualStyleBackColor = true;
            // 
            // chbArt
            // 
            this.chbArt.AutoSize = true;
            this.chbArt.Checked = true;
            this.chbArt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbArt.Location = new System.Drawing.Point(101, 29);
            this.chbArt.Margin = new System.Windows.Forms.Padding(2);
            this.chbArt.Name = "chbArt";
            this.chbArt.Size = new System.Drawing.Size(48, 16);
            this.chbArt.TabIndex = 3;
            this.chbArt.Text = "艺术";
            this.chbArt.UseVisualStyleBackColor = true;
            // 
            // chbGeneral
            // 
            this.chbGeneral.AutoSize = true;
            this.chbGeneral.Checked = true;
            this.chbGeneral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGeneral.Location = new System.Drawing.Point(49, 29);
            this.chbGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.chbGeneral.Name = "chbGeneral";
            this.chbGeneral.Size = new System.Drawing.Size(48, 16);
            this.chbGeneral.TabIndex = 3;
            this.chbGeneral.Text = "通用";
            this.tt1.SetToolTip(this.chbGeneral, "包含当天订单的通用图纸");
            this.chbGeneral.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 11F);
            this.btnSearch.Location = new System.Drawing.Point(475, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.tt1.SetToolTip(this.btnSearch, "查询当前用户所在班组有下达或开工状态的生产订单对应的图纸");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Font = new System.Drawing.Font("宋体", 11F);
            this.btnDownLoad.Location = new System.Drawing.Point(607, 3);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(60, 23);
            this.btnDownLoad.TabIndex = 2;
            this.btnDownLoad.Text = "下载";
            this.tt1.SetToolTip(this.btnDownLoad, "下载选定图纸");
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnBatDownLoad
            // 
            this.btnBatDownLoad.Enabled = false;
            this.btnBatDownLoad.Font = new System.Drawing.Font("宋体", 11F);
            this.btnBatDownLoad.Location = new System.Drawing.Point(673, 3);
            this.btnBatDownLoad.Name = "btnBatDownLoad";
            this.btnBatDownLoad.Size = new System.Drawing.Size(80, 23);
            this.btnBatDownLoad.TabIndex = 2;
            this.btnBatDownLoad.Text = "批量下载";
            this.tt1.SetToolTip(this.btnBatDownLoad, "下载当前用户所有对应图纸");
            this.btnBatDownLoad.UseVisualStyleBackColor = true;
            this.btnBatDownLoad.Click += new System.EventHandler(this.btnBatDownLoad_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 11F);
            this.btnOpen.Location = new System.Drawing.Point(541, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开";
            this.tt1.SetToolTip(this.btnOpen, "打开选定图纸");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("宋体", 12F);
            this.lblBarcode.Location = new System.Drawing.Point(3, 6);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(40, 16);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "图纸";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // tsmiSetting_tss1
            // 
            this.tsmiSetting_tss1.Name = "tsmiSetting_tss1";
            this.tsmiSetting_tss1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiSetting_Rigths
            // 
            this.tsmiSetting_Rigths.Enabled = false;
            this.tsmiSetting_Rigths.Name = "tsmiSetting_Rigths";
            this.tsmiSetting_Rigths.Size = new System.Drawing.Size(152, 22);
            this.tsmiSetting_Rigths.Text = "权限分配(&R)";
            this.tsmiSetting_Rigths.ToolTipText = "分配图纸管理权限(Admin)";
            this.tsmiSetting_Rigths.Click += new System.EventHandler(this.tsmiSetting_Rigths_Click);
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
            this.tsmiHelp_GetHelp.Size = new System.Drawing.Size(152, 22);
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
            this.dgv1.Location = new System.Drawing.Point(6, 78);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(801, 573);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv1_RowStateChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 662);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.msMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMail;
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            this.msMail.ResumeLayout(false);
            this.msMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Button btnSearch;
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
        private System.Windows.Forms.Button btnBatDownLoad;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_RLImport;
        private System.Windows.Forms.CheckBox chbGeneral;
        private System.Windows.Forms.CheckBox chbCust;
        private System.Windows.Forms.CheckBox chbArt;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_Manager;
        private System.Windows.Forms.ToolStripSeparator tsmiTool_tss2;
        private System.Windows.Forms.ToolStripSeparator tsmiTool_tss3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting_Rigths;
    }
}