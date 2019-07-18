namespace CBSys.WinForm
{
    partial class frmManage_RL_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage_RL_Edit));
            this.lblTrade = new System.Windows.Forms.Label();
            this.txtTrade = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCarSeries = new System.Windows.Forms.Label();
            this.txtCarSeries = new System.Windows.Forms.TextBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbl_Catetory_Tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(9, 21);
            this.lblTrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(53, 12);
            this.lblTrade.TabIndex = 0;
            this.lblTrade.Text = "商品名：";
            // 
            // txtTrade
            // 
            this.txtTrade.Location = new System.Drawing.Point(64, 18);
            this.txtTrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrade.Name = "txtTrade";
            this.txtTrade.Size = new System.Drawing.Size(272, 21);
            this.txtTrade.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 280);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 280);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCarSeries
            // 
            this.lblCarSeries.AutoSize = true;
            this.lblCarSeries.Location = new System.Drawing.Point(20, 46);
            this.lblCarSeries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarSeries.Name = "lblCarSeries";
            this.lblCarSeries.Size = new System.Drawing.Size(41, 12);
            this.lblCarSeries.TabIndex = 0;
            this.lblCarSeries.Text = "车系：";
            // 
            // txtCarSeries
            // 
            this.txtCarSeries.Location = new System.Drawing.Point(64, 43);
            this.txtCarSeries.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarSeries.Name = "txtCarSeries";
            this.txtCarSeries.Size = new System.Drawing.Size(272, 21);
            this.txtCarSeries.TabIndex = 2;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(20, 70);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(41, 12);
            this.lblCarType.TabIndex = 0;
            this.lblCarType.Text = "车型：";
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(64, 68);
            this.txtCarType.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(272, 21);
            this.txtCarType.TabIndex = 3;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(20, 95);
            this.lblCategoryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(41, 12);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "类别：";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Location = new System.Drawing.Point(8, 130);
            this.lblSourcePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(53, 12);
            this.lblSourcePath.TabIndex = 0;
            this.lblSourcePath.Text = "源路径：";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(10, 144);
            this.txtSourcePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtSourcePath.Multiline = true;
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(326, 100);
            this.txtSourcePath.TabIndex = 5;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(64, 93);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(79, 20);
            this.cbxCategory.TabIndex = 4;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lbl_Catetory_Tip
            // 
            this.lbl_Catetory_Tip.AutoSize = true;
            this.lbl_Catetory_Tip.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Catetory_Tip.ForeColor = System.Drawing.Color.Red;
            this.lbl_Catetory_Tip.Location = new System.Drawing.Point(147, 95);
            this.lbl_Catetory_Tip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Catetory_Tip.Name = "lbl_Catetory_Tip";
            this.lbl_Catetory_Tip.Size = new System.Drawing.Size(53, 12);
            this.lbl_Catetory_Tip.TabIndex = 8;
            this.lbl_Catetory_Tip.Text = "类别提示";
            // 
            // frmManage_RL_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 312);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Catetory_Tip);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.txtCarSeries);
            this.Controls.Add(this.txtTrade);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.lblCarSeries);
            this.Controls.Add(this.lblTrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(365, 350);
            this.MinimumSize = new System.Drawing.Size(365, 350);
            this.Name = "frmManage_RL_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图纸关联关系";
            this.Load += new System.EventHandler(this.frmManage_RL_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.TextBox txtTrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCarSeries;
        private System.Windows.Forms.TextBox txtCarSeries;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lbl_Catetory_Tip;
    }
}