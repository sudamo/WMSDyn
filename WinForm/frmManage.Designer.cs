namespace CBSys.WinForm
{
    partial class frmManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage));
            this.pl1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bt_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.bn_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.bn_tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGotoPage = new System.Windows.Forms.ToolStripButton();
            this.bn_tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_txtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.bn_lblSeparate = new System.Windows.Forms.ToolStripLabel();
            this.bn_lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.bn_tss6 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_cbxPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.bn_lblPageSize = new System.Windows.Forms.ToolStripLabel();
            this.bn_lblRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            this.tt1 = new System.Windows.Forms.ToolTip(this.components);
            this.pl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).BeginInit();
            this.bn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl1
            // 
            this.pl1.Controls.Add(this.lblName);
            this.pl1.Controls.Add(this.txtFileName);
            this.pl1.Controls.Add(this.btnEdit);
            this.pl1.Controls.Add(this.btnUnLock);
            this.pl1.Controls.Add(this.btnDelete);
            this.pl1.Controls.Add(this.btnSearch);
            this.pl1.Controls.Add(this.btnLock);
            this.pl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl1.Location = new System.Drawing.Point(0, 0);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(784, 41);
            this.pl1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "图纸名称：";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(83, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(200, 21);
            this.txtFileName.TabIndex = 6;
            this.tt1.SetToolTip(this.txtFileName, "输入部分图纸名称，可模糊查询图纸。");
            this.txtFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileName_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("宋体", 11F);
            this.btnEdit.Location = new System.Drawing.Point(421, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "编辑";
            this.tt1.SetToolTip(this.btnEdit, "编辑图纸");
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnUnLock
            // 
            this.btnUnLock.Font = new System.Drawing.Font("宋体", 11F);
            this.btnUnLock.Location = new System.Drawing.Point(553, 12);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(60, 23);
            this.btnUnLock.TabIndex = 3;
            this.btnUnLock.Text = "解锁";
            this.tt1.SetToolTip(this.btnUnLock, "解除锁定图纸");
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 11F);
            this.btnDelete.Location = new System.Drawing.Point(355, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.tt1.SetToolTip(this.btnDelete, "删除图纸");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 11F);
            this.btnSearch.Location = new System.Drawing.Point(289, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.tt1.SetToolTip(this.btnSearch, "查询图纸");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("宋体", 11F);
            this.btnLock.Location = new System.Drawing.Point(487, 12);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(60, 23);
            this.btnLock.TabIndex = 5;
            this.btnLock.Text = "锁定";
            this.tt1.SetToolTip(this.btnLock, "锁定图纸");
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(0, 47);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(784, 487);
            this.dgv1.TabIndex = 1;
            this.dgv1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv1_RowStateChanged);
            // 
            // bn1
            // 
            this.bn1.AddNewItem = null;
            this.bn1.CountItem = null;
            this.bn1.DeleteItem = null;
            this.bn1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_tss1,
            this.btnPrevious,
            this.bn_tss2,
            this.btnNext,
            this.bn_tss3,
            this.bn_tss4,
            this.btnGotoPage,
            this.bn_tss5,
            this.bn_txtCurrentPage,
            this.bn_lblSeparate,
            this.bn_lblPageCount,
            this.bn_tss6,
            this.bn_cbxPageSize,
            this.bn_lblPageSize,
            this.bn_lblRecordCount});
            this.bn1.Location = new System.Drawing.Point(0, 537);
            this.bn1.MoveFirstItem = null;
            this.bn1.MoveLastItem = null;
            this.bn1.MoveNextItem = null;
            this.bn1.MovePreviousItem = null;
            this.bn1.Name = "bn1";
            this.bn1.PositionItem = null;
            this.bn1.Size = new System.Drawing.Size(784, 25);
            this.bn1.TabIndex = 21;
            this.bn1.Text = "bindingNavigator1";
            this.tt1.SetToolTip(this.bn1, "分页导航");
            this.bn1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bn1_ItemClicked);
            // 
            // bt_tss1
            // 
            this.bt_tss1.Name = "bt_tss1";
            this.bt_tss1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoToolTip = false;
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(63, 22);
            this.btnPrevious.Text = "上一页(&P)";
            // 
            // bn_tss2
            // 
            this.bn_tss2.Name = "bn_tss2";
            this.bn_tss2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNext
            // 
            this.btnNext.AutoToolTip = false;
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 22);
            this.btnNext.Text = "下一页(&N)";
            // 
            // bn_tss3
            // 
            this.bn_tss3.Name = "bn_tss3";
            this.bn_tss3.Size = new System.Drawing.Size(6, 25);
            // 
            // bn_tss4
            // 
            this.bn_tss4.Name = "bn_tss4";
            this.bn_tss4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGotoPage
            // 
            this.btnGotoPage.AutoToolTip = false;
            this.btnGotoPage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGotoPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGotoPage.Image = ((System.Drawing.Image)(resources.GetObject("btnGotoPage.Image")));
            this.btnGotoPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGotoPage.Name = "btnGotoPage";
            this.btnGotoPage.Size = new System.Drawing.Size(65, 22);
            this.btnGotoPage.Text = "跳转到(&G)";
            // 
            // bn_tss5
            // 
            this.bn_tss5.Name = "bn_tss5";
            this.bn_tss5.Size = new System.Drawing.Size(6, 25);
            // 
            // bn_txtCurrentPage
            // 
            this.bn_txtCurrentPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bn_txtCurrentPage.Name = "bn_txtCurrentPage";
            this.bn_txtCurrentPage.Size = new System.Drawing.Size(40, 25);
            // 
            // bn_lblSeparate
            // 
            this.bn_lblSeparate.Name = "bn_lblSeparate";
            this.bn_lblSeparate.Size = new System.Drawing.Size(45, 22);
            this.bn_lblSeparate.Text = "页 / 共";
            // 
            // bn_lblPageCount
            // 
            this.bn_lblPageCount.Name = "bn_lblPageCount";
            this.bn_lblPageCount.Size = new System.Drawing.Size(56, 22);
            this.bn_lblPageCount.Text = "@总页数";
            // 
            // bn_tss6
            // 
            this.bn_tss6.Name = "bn_tss6";
            this.bn_tss6.Size = new System.Drawing.Size(6, 25);
            // 
            // bn_cbxPageSize
            // 
            this.bn_cbxPageSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bn_cbxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bn_cbxPageSize.Name = "bn_cbxPageSize";
            this.bn_cbxPageSize.Size = new System.Drawing.Size(75, 25);
            this.bn_cbxPageSize.SelectedIndexChanged += new System.EventHandler(this.bn_cbxPageSize_SelectedIndexChanged);
            // 
            // bn_lblPageSize
            // 
            this.bn_lblPageSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bn_lblPageSize.Name = "bn_lblPageSize";
            this.bn_lblPageSize.Size = new System.Drawing.Size(56, 22);
            this.bn_lblPageSize.Text = "每页显示";
            // 
            // bn_lblRecordCount
            // 
            this.bn_lblRecordCount.Name = "bn_lblRecordCount";
            this.bn_lblRecordCount.Size = new System.Drawing.Size(68, 22);
            this.bn_lblRecordCount.Text = "@总记录数";
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.bn1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.pl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理图纸";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManage_Load);
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).EndInit();
            this.bn1.ResumeLayout(false);
            this.bn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnUnLock;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingNavigator bn1;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripSeparator bt_tss1;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripSeparator bn_tss2;
        private System.Windows.Forms.ToolStripSeparator bn_tss3;
        private System.Windows.Forms.ToolStripButton btnGotoPage;
        private System.Windows.Forms.ToolStripSeparator bn_tss4;
        private System.Windows.Forms.ToolStripTextBox bn_txtCurrentPage;
        private System.Windows.Forms.ToolStripLabel bn_lblSeparate;
        private System.Windows.Forms.ToolStripLabel bn_lblPageCount;
        private System.Windows.Forms.ToolStripSeparator bn_tss5;
        private System.Windows.Forms.BindingSource bs1;
        private System.Windows.Forms.ToolTip tt1;
        private System.Windows.Forms.ToolStripSeparator bn_tss6;
        private System.Windows.Forms.ToolStripLabel bn_lblPageSize;
        private System.Windows.Forms.ToolStripComboBox bn_cbxPageSize;
        private System.Windows.Forms.ToolStripLabel bn_lblRecordCount;
    }
}