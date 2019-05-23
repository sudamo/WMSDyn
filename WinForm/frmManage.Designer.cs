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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bt_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_txtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.bn_lblSeparate = new System.Windows.Forms.ToolStripLabel();
            this.bn_lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.bn_cbxPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.bn_lblPageSize = new System.Windows.Forms.ToolStripLabel();
            this.bn_lblRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.tt1 = new System.Windows.Forms.ToolTip(this.components);
            this.bnTop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnTop_lblName = new System.Windows.Forms.ToolStripLabel();
            this.bnTop_txtName = new System.Windows.Forms.ToolStripTextBox();
            this.bnTop_tss = new System.Windows.Forms.ToolStripSeparator();
            this.bnTop_cbxIsNull = new System.Windows.Forms.ToolStripComboBox();
            this.bnTop_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnTop_btnSearch = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnEdit = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnLock = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnUnLock = new System.Windows.Forms.ToolStripButton();
            this.bnTop_Export = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnGotoPage = new System.Windows.Forms.ToolStripButton();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).BeginInit();
            this.bn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTop)).BeginInit();
            this.bnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(0, 28);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(784, 506);
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
            this.btnGotoPage,
            this.bn_txtCurrentPage,
            this.bn_lblSeparate,
            this.bn_lblPageCount,
            this.bn_cbxPageSize,
            this.bn_lblPageSize,
            this.bn_tss4,
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
            // bn_tss2
            // 
            this.bn_tss2.Name = "bn_tss2";
            this.bn_tss2.Size = new System.Drawing.Size(6, 25);
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
            // bn_txtCurrentPage
            // 
            this.bn_txtCurrentPage.BackColor = System.Drawing.Color.LightGray;
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
            // bn_cbxPageSize
            // 
            this.bn_cbxPageSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bn_cbxPageSize.BackColor = System.Drawing.SystemColors.Info;
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
            // bnTop
            // 
            this.bnTop.AddNewItem = null;
            this.bnTop.CountItem = null;
            this.bnTop.DeleteItem = null;
            this.bnTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnTop_lblName,
            this.bnTop_txtName,
            this.bnTop_tss,
            this.bnTop_cbxIsNull,
            this.bnTop_tss2,
            this.bnTop_btnSearch,
            this.bnTop_btnEdit,
            this.bnTop_btnDelete,
            this.bnTop_btnLock,
            this.bnTop_btnUnLock,
            this.bnTop_Export});
            this.bnTop.Location = new System.Drawing.Point(0, 0);
            this.bnTop.MoveFirstItem = null;
            this.bnTop.MoveLastItem = null;
            this.bnTop.MoveNextItem = null;
            this.bnTop.MovePreviousItem = null;
            this.bnTop.Name = "bnTop";
            this.bnTop.PositionItem = null;
            this.bnTop.Size = new System.Drawing.Size(784, 25);
            this.bnTop.TabIndex = 22;
            this.bnTop.Text = "bindingNavigator1";
            this.bnTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bnTop_ItemClicked);
            // 
            // bnTop_lblName
            // 
            this.bnTop_lblName.Name = "bnTop_lblName";
            this.bnTop_lblName.Size = new System.Drawing.Size(56, 22);
            this.bnTop_lblName.Text = "图纸名称";
            this.bnTop_lblName.ToolTipText = "图纸名称（包含）";
            // 
            // bnTop_txtName
            // 
            this.bnTop_txtName.Name = "bnTop_txtName";
            this.bnTop_txtName.Size = new System.Drawing.Size(150, 25);
            // 
            // bnTop_tss
            // 
            this.bnTop_tss.Name = "bnTop_tss";
            this.bnTop_tss.Size = new System.Drawing.Size(6, 25);
            // 
            // bnTop_cbxIsNull
            // 
            this.bnTop_cbxIsNull.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bnTop_cbxIsNull.DropDownWidth = 75;
            this.bnTop_cbxIsNull.Name = "bnTop_cbxIsNull";
            this.bnTop_cbxIsNull.Size = new System.Drawing.Size(75, 25);
            // 
            // bnTop_tss2
            // 
            this.bnTop_tss2.Name = "bnTop_tss2";
            this.bnTop_tss2.Size = new System.Drawing.Size(6, 25);
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
            // bnTop_btnEdit
            // 
            this.bnTop_btnEdit.Enabled = false;
            this.bnTop_btnEdit.Image = global::CBSys.WinForm.Properties.Resources.book_edit;
            this.bnTop_btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnEdit.Name = "bnTop_btnEdit";
            this.bnTop_btnEdit.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnEdit.Tag = "2";
            this.bnTop_btnEdit.Text = "编辑";
            // 
            // bnTop_btnDelete
            // 
            this.bnTop_btnDelete.Image = global::CBSys.WinForm.Properties.Resources.delete;
            this.bnTop_btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnDelete.Name = "bnTop_btnDelete";
            this.bnTop_btnDelete.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnDelete.Tag = "3";
            this.bnTop_btnDelete.Text = "删除";
            // 
            // bnTop_btnLock
            // 
            this.bnTop_btnLock.Image = global::CBSys.WinForm.Properties.Resources._lock;
            this.bnTop_btnLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnLock.Name = "bnTop_btnLock";
            this.bnTop_btnLock.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnLock.Tag = "4";
            this.bnTop_btnLock.Text = "锁定";
            // 
            // bnTop_btnUnLock
            // 
            this.bnTop_btnUnLock.Image = global::CBSys.WinForm.Properties.Resources.key;
            this.bnTop_btnUnLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnUnLock.Name = "bnTop_btnUnLock";
            this.bnTop_btnUnLock.Size = new System.Drawing.Size(52, 22);
            this.bnTop_btnUnLock.Tag = "5";
            this.bnTop_btnUnLock.Text = "解锁";
            // 
            // bnTop_Export
            // 
            this.bnTop_Export.Enabled = false;
            this.bnTop_Export.Image = global::CBSys.WinForm.Properties.Resources.table_excel;
            this.bnTop_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_Export.Name = "bnTop_Export";
            this.bnTop_Export.Size = new System.Drawing.Size(76, 22);
            this.bnTop_Export.Tag = "6";
            this.bnTop_Export.Text = "导出报表";
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoToolTip = false;
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::CBSys.WinForm.Properties.Resources.resultset_previous;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnPrevious.Tag = "1";
            // 
            // btnNext
            // 
            this.btnNext.AutoToolTip = false;
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::CBSys.WinForm.Properties.Resources.resultset_next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Tag = "2";
            // 
            // btnGotoPage
            // 
            this.btnGotoPage.AutoToolTip = false;
            this.btnGotoPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnGotoPage.Image = global::CBSys.WinForm.Properties.Resources.arrow_redo;
            this.btnGotoPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGotoPage.Name = "btnGotoPage";
            this.btnGotoPage.Size = new System.Drawing.Size(64, 22);
            this.btnGotoPage.Tag = "3";
            this.btnGotoPage.Text = "跳转到";
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.bnTop);
            this.Controls.Add(this.bn1);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理图纸";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).EndInit();
            this.bn1.ResumeLayout(false);
            this.bn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTop)).EndInit();
            this.bnTop.ResumeLayout(false);
            this.bnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv1;
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
        private System.Windows.Forms.BindingSource bs1;
        private System.Windows.Forms.ToolTip tt1;
        private System.Windows.Forms.ToolStripLabel bn_lblPageSize;
        private System.Windows.Forms.ToolStripComboBox bn_cbxPageSize;
        private System.Windows.Forms.ToolStripLabel bn_lblRecordCount;
        private System.Windows.Forms.BindingNavigator bnTop;
        private System.Windows.Forms.ToolStripLabel bnTop_lblName;
        private System.Windows.Forms.ToolStripTextBox bnTop_txtName;
        private System.Windows.Forms.ToolStripSeparator bnTop_tss;
        private System.Windows.Forms.ToolStripButton bnTop_btnSearch;
        private System.Windows.Forms.ToolStripButton bnTop_btnEdit;
        private System.Windows.Forms.ToolStripButton bnTop_btnDelete;
        private System.Windows.Forms.ToolStripButton bnTop_btnLock;
        private System.Windows.Forms.ToolStripButton bnTop_btnUnLock;
        private System.Windows.Forms.ToolStripButton bnTop_Export;
        private System.Windows.Forms.ToolStripComboBox bnTop_cbxIsNull;
        private System.Windows.Forms.ToolStripSeparator bnTop_tss2;
    }
}