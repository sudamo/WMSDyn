namespace CBSys.WinForm
{
    partial class frmManage_RL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage_RL));
            this.bnTop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnTop_lblTrade = new System.Windows.Forms.ToolStripLabel();
            this.bnTop_txtTrade = new System.Windows.Forms.ToolStripTextBox();
            this.bnTop_lblCarSeries = new System.Windows.Forms.ToolStripLabel();
            this.bnTop_txtCarSeries = new System.Windows.Forms.ToolStripTextBox();
            this.bnTop_lblCarType = new System.Windows.Forms.ToolStripLabel();
            this.bnTop_txtCarType = new System.Windows.Forms.ToolStripTextBox();
            this.bnTop_tss = new System.Windows.Forms.ToolStripSeparator();
            this.bnTop_btnSearch = new System.Windows.Forms.ToolStripButton();
            this.bnTop_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnTop_btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnEdit = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnClear = new System.Windows.Forms.ToolStripButton();
            this.bnTop_btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bnBottom = new System.Windows.Forms.BindingNavigator(this.components);
            this.bt_tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.bn_tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.bn_tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGotoPage = new System.Windows.Forms.ToolStripButton();
            this.bn_txtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.bn_lblSeparate = new System.Windows.Forms.ToolStripLabel();
            this.bn_lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.bn_cbxPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.bn_lblPageSize = new System.Windows.Forms.ToolStripLabel();
            this.bn_tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_lblRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.bn_tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_lblRLCount = new System.Windows.Forms.ToolStripLabel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms1_Copy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bnTop)).BeginInit();
            this.bnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBottom)).BeginInit();
            this.bnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnTop
            // 
            this.bnTop.AddNewItem = null;
            this.bnTop.CountItem = null;
            this.bnTop.DeleteItem = null;
            this.bnTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnTop_lblTrade,
            this.bnTop_txtTrade,
            this.bnTop_lblCarSeries,
            this.bnTop_txtCarSeries,
            this.bnTop_lblCarType,
            this.bnTop_txtCarType,
            this.bnTop_tss,
            this.bnTop_btnSearch,
            this.bnTop_tss2,
            this.bnTop_btnAdd,
            this.bnTop_btnEdit,
            this.bnTop_btnClear,
            this.bnTop_btnDelete});
            this.bnTop.Location = new System.Drawing.Point(0, 0);
            this.bnTop.MoveFirstItem = null;
            this.bnTop.MoveLastItem = null;
            this.bnTop.MoveNextItem = null;
            this.bnTop.MovePreviousItem = null;
            this.bnTop.Name = "bnTop";
            this.bnTop.PositionItem = null;
            this.bnTop.Size = new System.Drawing.Size(754, 27);
            this.bnTop.TabIndex = 23;
            this.bnTop.Text = "bindingNavigator1";
            this.bnTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bnTop_ItemClicked);
            // 
            // bnTop_lblTrade
            // 
            this.bnTop_lblTrade.Name = "bnTop_lblTrade";
            this.bnTop_lblTrade.Size = new System.Drawing.Size(44, 24);
            this.bnTop_lblTrade.Text = "商品名";
            this.bnTop_lblTrade.ToolTipText = "图纸名称（包含）";
            // 
            // bnTop_txtTrade
            // 
            this.bnTop_txtTrade.Name = "bnTop_txtTrade";
            this.bnTop_txtTrade.Size = new System.Drawing.Size(76, 27);
            // 
            // bnTop_lblCarSeries
            // 
            this.bnTop_lblCarSeries.Name = "bnTop_lblCarSeries";
            this.bnTop_lblCarSeries.Size = new System.Drawing.Size(32, 24);
            this.bnTop_lblCarSeries.Text = "车系";
            // 
            // bnTop_txtCarSeries
            // 
            this.bnTop_txtCarSeries.Name = "bnTop_txtCarSeries";
            this.bnTop_txtCarSeries.Size = new System.Drawing.Size(76, 27);
            // 
            // bnTop_lblCarType
            // 
            this.bnTop_lblCarType.Name = "bnTop_lblCarType";
            this.bnTop_lblCarType.Size = new System.Drawing.Size(32, 24);
            this.bnTop_lblCarType.Text = "车型";
            // 
            // bnTop_txtCarType
            // 
            this.bnTop_txtCarType.Name = "bnTop_txtCarType";
            this.bnTop_txtCarType.Size = new System.Drawing.Size(76, 27);
            // 
            // bnTop_tss
            // 
            this.bnTop_tss.Name = "bnTop_tss";
            this.bnTop_tss.Size = new System.Drawing.Size(6, 27);
            // 
            // bnTop_btnSearch
            // 
            this.bnTop_btnSearch.Image = global::CBSys.WinForm.Properties.Resources.zoom;
            this.bnTop_btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnSearch.Name = "bnTop_btnSearch";
            this.bnTop_btnSearch.Size = new System.Drawing.Size(56, 24);
            this.bnTop_btnSearch.Tag = "1";
            this.bnTop_btnSearch.Text = "查询";
            // 
            // bnTop_tss2
            // 
            this.bnTop_tss2.Name = "bnTop_tss2";
            this.bnTop_tss2.Size = new System.Drawing.Size(6, 27);
            // 
            // bnTop_btnAdd
            // 
            this.bnTop_btnAdd.Image = global::CBSys.WinForm.Properties.Resources.add;
            this.bnTop_btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnAdd.Name = "bnTop_btnAdd";
            this.bnTop_btnAdd.Size = new System.Drawing.Size(56, 24);
            this.bnTop_btnAdd.Tag = "2";
            this.bnTop_btnAdd.Text = "添加";
            // 
            // bnTop_btnEdit
            // 
            this.bnTop_btnEdit.Image = global::CBSys.WinForm.Properties.Resources.book_edit;
            this.bnTop_btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnEdit.Name = "bnTop_btnEdit";
            this.bnTop_btnEdit.Size = new System.Drawing.Size(56, 24);
            this.bnTop_btnEdit.Tag = "3";
            this.bnTop_btnEdit.Text = "编辑";
            // 
            // bnTop_btnClear
            // 
            this.bnTop_btnClear.Image = global::CBSys.WinForm.Properties.Resources.book_delete;
            this.bnTop_btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnClear.Name = "bnTop_btnClear";
            this.bnTop_btnClear.Size = new System.Drawing.Size(56, 24);
            this.bnTop_btnClear.Tag = "4";
            this.bnTop_btnClear.Text = "清除";
            this.bnTop_btnClear.ToolTipText = "清除无效关联关系";
            // 
            // bnTop_btnDelete
            // 
            this.bnTop_btnDelete.Image = global::CBSys.WinForm.Properties.Resources.delete;
            this.bnTop_btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnTop_btnDelete.Name = "bnTop_btnDelete";
            this.bnTop_btnDelete.Size = new System.Drawing.Size(56, 24);
            this.bnTop_btnDelete.Tag = "5";
            this.bnTop_btnDelete.Text = "删除";
            this.bnTop_btnDelete.ToolTipText = "删除选中关联关系";
            // 
            // bnBottom
            // 
            this.bnBottom.AddNewItem = null;
            this.bnBottom.CountItem = null;
            this.bnBottom.DeleteItem = null;
            this.bnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bn_lblRecordCount,
            this.bn_tss5,
            this.bn_lblRLCount});
            this.bnBottom.Location = new System.Drawing.Point(0, 550);
            this.bnBottom.MoveFirstItem = null;
            this.bnBottom.MoveLastItem = null;
            this.bnBottom.MoveNextItem = null;
            this.bnBottom.MovePreviousItem = null;
            this.bnBottom.Name = "bnBottom";
            this.bnBottom.PositionItem = null;
            this.bnBottom.Size = new System.Drawing.Size(754, 27);
            this.bnBottom.TabIndex = 24;
            this.bnBottom.Text = "bindingNavigator1";
            this.bnBottom.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bnBottom_ItemClicked);
            // 
            // bt_tss1
            // 
            this.bt_tss1.Name = "bt_tss1";
            this.bt_tss1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoToolTip = false;
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::CBSys.WinForm.Properties.Resources.resultset_previous;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 24);
            this.btnPrevious.Tag = "1";
            // 
            // bn_tss2
            // 
            this.bn_tss2.Name = "bn_tss2";
            this.bn_tss2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNext
            // 
            this.btnNext.AutoToolTip = false;
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::CBSys.WinForm.Properties.Resources.resultset_next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 24);
            this.btnNext.Tag = "2";
            // 
            // bn_tss3
            // 
            this.bn_tss3.Name = "bn_tss3";
            this.bn_tss3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnGotoPage
            // 
            this.btnGotoPage.AutoToolTip = false;
            this.btnGotoPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnGotoPage.Image = global::CBSys.WinForm.Properties.Resources.arrow_redo;
            this.btnGotoPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGotoPage.Name = "btnGotoPage";
            this.btnGotoPage.Size = new System.Drawing.Size(68, 24);
            this.btnGotoPage.Tag = "3";
            this.btnGotoPage.Text = "跳转到";
            // 
            // bn_txtCurrentPage
            // 
            this.bn_txtCurrentPage.BackColor = System.Drawing.Color.LightGray;
            this.bn_txtCurrentPage.Name = "bn_txtCurrentPage";
            this.bn_txtCurrentPage.Size = new System.Drawing.Size(40, 27);
            // 
            // bn_lblSeparate
            // 
            this.bn_lblSeparate.Name = "bn_lblSeparate";
            this.bn_lblSeparate.Size = new System.Drawing.Size(45, 24);
            this.bn_lblSeparate.Text = "页 / 共";
            // 
            // bn_lblPageCount
            // 
            this.bn_lblPageCount.Name = "bn_lblPageCount";
            this.bn_lblPageCount.Size = new System.Drawing.Size(56, 24);
            this.bn_lblPageCount.Text = "@总页数";
            // 
            // bn_cbxPageSize
            // 
            this.bn_cbxPageSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bn_cbxPageSize.BackColor = System.Drawing.SystemColors.Info;
            this.bn_cbxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bn_cbxPageSize.Name = "bn_cbxPageSize";
            this.bn_cbxPageSize.Size = new System.Drawing.Size(75, 27);
            this.bn_cbxPageSize.SelectedIndexChanged += new System.EventHandler(this.bn_cbxPageSize_SelectedIndexChanged);
            // 
            // bn_lblPageSize
            // 
            this.bn_lblPageSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bn_lblPageSize.Name = "bn_lblPageSize";
            this.bn_lblPageSize.Size = new System.Drawing.Size(56, 24);
            this.bn_lblPageSize.Text = "每页显示";
            // 
            // bn_tss4
            // 
            this.bn_tss4.Name = "bn_tss4";
            this.bn_tss4.Size = new System.Drawing.Size(6, 27);
            // 
            // bn_lblRecordCount
            // 
            this.bn_lblRecordCount.Name = "bn_lblRecordCount";
            this.bn_lblRecordCount.Size = new System.Drawing.Size(68, 24);
            this.bn_lblRecordCount.Text = "@总记录数";
            // 
            // bn_tss5
            // 
            this.bn_tss5.Name = "bn_tss5";
            this.bn_tss5.Size = new System.Drawing.Size(6, 27);
            // 
            // bn_lblRLCount
            // 
            this.bn_lblRLCount.Name = "bn_lblRLCount";
            this.bn_lblRLCount.Size = new System.Drawing.Size(104, 24);
            this.bn_lblRLCount.Text = "图纸关联总数量：";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(0, 25);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(745, 526);
            this.dgv1.TabIndex = 25;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Edit);
            this.dgv1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            this.dgv1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv1_RowStateChanged);
            // 
            // cms1
            // 
            this.cms1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms1_Copy});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(137, 26);
            // 
            // cms1_Copy
            // 
            this.cms1_Copy.Name = "cms1_Copy";
            this.cms1_Copy.Size = new System.Drawing.Size(136, 22);
            this.cms1_Copy.Tag = "1";
            this.cms1_Copy.Text = "复制当前行";
            this.cms1_Copy.Click += new System.EventHandler(this.cms1_Copy_Click);
            // 
            // frmManage_RL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.bnBottom);
            this.Controls.Add(this.bnTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(770, 615);
            this.Name = "frmManage_RL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图纸关联关系管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManage_RL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnTop)).EndInit();
            this.bnTop.ResumeLayout(false);
            this.bnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBottom)).EndInit();
            this.bnBottom.ResumeLayout(false);
            this.bnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnTop;
        private System.Windows.Forms.ToolStripLabel bnTop_lblTrade;
        private System.Windows.Forms.ToolStripTextBox bnTop_txtTrade;
        private System.Windows.Forms.ToolStripSeparator bnTop_tss;
        private System.Windows.Forms.ToolStripButton bnTop_btnSearch;
        private System.Windows.Forms.ToolStripSeparator bnTop_tss2;
        private System.Windows.Forms.ToolStripButton bnTop_btnEdit;
        private System.Windows.Forms.ToolStripButton bnTop_btnDelete;
        private System.Windows.Forms.ToolStripLabel bnTop_lblCarSeries;
        private System.Windows.Forms.ToolStripTextBox bnTop_txtCarSeries;
        private System.Windows.Forms.ToolStripLabel bnTop_lblCarType;
        private System.Windows.Forms.ToolStripTextBox bnTop_txtCarType;
        private System.Windows.Forms.ToolStripButton bnTop_btnClear;
        private System.Windows.Forms.BindingNavigator bnBottom;
        private System.Windows.Forms.ToolStripSeparator bt_tss1;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripSeparator bn_tss2;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripSeparator bn_tss3;
        private System.Windows.Forms.ToolStripButton btnGotoPage;
        private System.Windows.Forms.ToolStripTextBox bn_txtCurrentPage;
        private System.Windows.Forms.ToolStripLabel bn_lblSeparate;
        private System.Windows.Forms.ToolStripLabel bn_lblPageCount;
        private System.Windows.Forms.ToolStripComboBox bn_cbxPageSize;
        private System.Windows.Forms.ToolStripLabel bn_lblPageSize;
        private System.Windows.Forms.ToolStripSeparator bn_tss4;
        private System.Windows.Forms.ToolStripLabel bn_lblRecordCount;
        private System.Windows.Forms.ToolStripSeparator bn_tss5;
        private System.Windows.Forms.ToolStripLabel bn_lblRLCount;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.BindingSource bs1;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem cms1_Copy;
        private System.Windows.Forms.ToolStripButton bnTop_btnAdd;
    }
}