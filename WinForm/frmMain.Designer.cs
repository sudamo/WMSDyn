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
            this.chbGeneral = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
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
            this.tsmiSetting_User = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSetting1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetting_SynUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting_SynDep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_batchImport = new System.Windows.Forms.ToolStripMenuItem();
            this.smiTool_RLImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTool1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTool_DownLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool_Upload = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txtBarcode.Location = new System.Drawing.Point(53, 3);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(353, 21);
            this.txtBarcode.TabIndex = 1;
            this.tt1.SetToolTip(this.txtBarcode, "扫描条码到此输入框");
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // pl1
            // 
            this.pl1.Controls.Add(this.chbGeneral);
            this.pl1.Controls.Add(this.btnSearch);
            this.pl1.Controls.Add(this.btnUnLock);
            this.pl1.Controls.Add(this.btnDelete);
            this.pl1.Controls.Add(this.btnLock);
            this.pl1.Controls.Add(this.btnBatDownLoad);
            this.pl1.Controls.Add(this.btnOpen);
            this.pl1.Controls.Add(this.lblBarcode);
            this.pl1.Controls.Add(this.txtBarcode);
            this.pl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl1.Location = new System.Drawing.Point(0, 25);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(562, 58);
            this.pl1.TabIndex = 2;
            // 
            // chbGeneral
            // 
            this.chbGeneral.AutoSize = true;
            this.chbGeneral.Location = new System.Drawing.Point(411, 7);
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
            this.btnSearch.Location = new System.Drawing.Point(472, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询图纸";
            this.tt1.SetToolTip(this.btnSearch, "查询当前用户所有图纸");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUnLock
            // 
            this.btnUnLock.Font = new System.Drawing.Font("宋体", 11F);
            this.btnUnLock.Location = new System.Drawing.Point(411, 30);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(56, 23);
            this.btnUnLock.TabIndex = 2;
            this.btnUnLock.Text = "解锁";
            this.tt1.SetToolTip(this.btnUnLock, "解锁被锁定的图纸");
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 11F);
            this.btnDelete.Location = new System.Drawing.Point(116, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.tt1.SetToolTip(this.btnDelete, "删除当前图纸");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("宋体", 11F);
            this.btnLock.Location = new System.Drawing.Point(349, 30);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(56, 23);
            this.btnLock.TabIndex = 2;
            this.btnLock.Text = "锁定";
            this.tt1.SetToolTip(this.btnLock, "锁定当前图纸使其不能开料");
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnBatDownLoad
            // 
            this.btnBatDownLoad.Font = new System.Drawing.Font("宋体", 11F);
            this.btnBatDownLoad.Location = new System.Drawing.Point(472, 30);
            this.btnBatDownLoad.Name = "btnBatDownLoad";
            this.btnBatDownLoad.Size = new System.Drawing.Size(80, 23);
            this.btnBatDownLoad.TabIndex = 2;
            this.btnBatDownLoad.Text = "下载图纸";
            this.tt1.SetToolTip(this.btnBatDownLoad, "下载当前用户所有图纸");
            this.btnBatDownLoad.UseVisualStyleBackColor = true;
            this.btnBatDownLoad.Click += new System.EventHandler(this.btnBatDownLoad_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 11F);
            this.btnOpen.Location = new System.Drawing.Point(53, 30);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开";
            this.tt1.SetToolTip(this.btnOpen, "打开在条码对应的图纸");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("宋体", 12F);
            this.lblBarcode.Location = new System.Drawing.Point(3, 7);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(48, 16);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = " 条码";
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
            this.msMail.Size = new System.Drawing.Size(562, 25);
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
            this.tsmiFile_New.Click += new System.EventHandler(this.tsmiFile_New_Click);
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
            this.tsmiSetting_User,
            this.tssSetting1,
            this.tsmiSetting_SynUser,
            this.tsmiSetting_SynDep});
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(59, 21);
            this.tsmiSetting.Text = "配置(&S)";
            // 
            // tsmiSetting_User
            // 
            this.tsmiSetting_User.Name = "tsmiSetting_User";
            this.tsmiSetting_User.Size = new System.Drawing.Size(139, 22);
            this.tsmiSetting_User.Text = "用户配置";
            this.tsmiSetting_User.Click += new System.EventHandler(this.tsmiSetting_User_Click);
            // 
            // tssSetting1
            // 
            this.tssSetting1.Name = "tssSetting1";
            this.tssSetting1.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiSetting_SynUser
            // 
            this.tsmiSetting_SynUser.Name = "tsmiSetting_SynUser";
            this.tsmiSetting_SynUser.Size = new System.Drawing.Size(139, 22);
            this.tsmiSetting_SynUser.Text = "同步K3用户";
            this.tsmiSetting_SynUser.Click += new System.EventHandler(this.tsmiSetting_SynUser_Click);
            // 
            // tsmiSetting_SynDep
            // 
            this.tsmiSetting_SynDep.Name = "tsmiSetting_SynDep";
            this.tsmiSetting_SynDep.Size = new System.Drawing.Size(139, 22);
            this.tsmiSetting_SynDep.Text = "同步班组";
            this.tsmiSetting_SynDep.Click += new System.EventHandler(this.tsmiSetting_SynDep_Click);
            // 
            // tsmiTool
            // 
            this.tsmiTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTool_Import,
            this.tsmiTool_batchImport,
            this.smiTool_RLImport,
            this.tssTool1,
            this.tsmiTool_DownLoad,
            this.tsmiTool_Upload});
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(59, 21);
            this.tsmiTool.Text = "工具(&T)";
            // 
            // tsmiTool_Import
            // 
            this.tsmiTool_Import.Name = "tsmiTool_Import";
            this.tsmiTool_Import.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_Import.Text = "上传图纸(&I)";
            this.tsmiTool_Import.ToolTipText = "上传单个图纸到数据库中";
            this.tsmiTool_Import.Click += new System.EventHandler(this.tsmiTool_Import_Click);
            // 
            // tsmiTool_batchImport
            // 
            this.tsmiTool_batchImport.Name = "tsmiTool_batchImport";
            this.tsmiTool_batchImport.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_batchImport.Text = "批量上传图纸(&B)";
            this.tsmiTool_batchImport.ToolTipText = "批量上传图纸到数据库中";
            this.tsmiTool_batchImport.Click += new System.EventHandler(this.tsmiTool_batchImport_Click);
            // 
            // smiTool_RLImport
            // 
            this.smiTool_RLImport.Name = "smiTool_RLImport";
            this.smiTool_RLImport.Size = new System.Drawing.Size(165, 22);
            this.smiTool_RLImport.Text = "上传图纸关联(&R)";
            this.smiTool_RLImport.ToolTipText = "根据模板上传图纸对应关系";
            this.smiTool_RLImport.Click += new System.EventHandler(this.smiTool_RLImport_Click);
            // 
            // tssTool1
            // 
            this.tssTool1.Name = "tssTool1";
            this.tssTool1.Size = new System.Drawing.Size(162, 6);
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
            this.tsmiTool_Upload.Name = "tsmiTool_Upload";
            this.tsmiTool_Upload.Size = new System.Drawing.Size(165, 22);
            this.tsmiTool_Upload.Text = "上传导入模板(&U)";
            this.tsmiTool_Upload.ToolTipText = "上传或更新图纸关联模板";
            this.tsmiTool_Upload.Click += new System.EventHandler(this.tsmiTool_Upload_Click);
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
            this.tsmiHelp_GetHelp.Name = "tsmiHelp_GetHelp";
            this.tsmiHelp_GetHelp.Size = new System.Drawing.Size(124, 22);
            this.tsmiHelp_GetHelp.Text = "获取帮助";
            this.tsmiHelp_GetHelp.Click += new System.EventHandler(this.tsmiHelp_GetHelp_Click);
            // 
            // tt1
            // 
            this.tt1.IsBalloon = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(0, 88);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.Size = new System.Drawing.Size(554, 345);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv1_RowStateChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 442);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.msMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMail;
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
        private System.Windows.Forms.ToolStripSeparator tssTool1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_DownLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool_Upload;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp_GetHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting_SynUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting_User;
        private System.Windows.Forms.ToolStripSeparator tssSetting1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting_SynDep;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip tt1;
        private System.Windows.Forms.Button btnBatDownLoad;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnUnLock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.ToolStripMenuItem smiTool_RLImport;
        private System.Windows.Forms.CheckBox chbGeneral;
    }
}