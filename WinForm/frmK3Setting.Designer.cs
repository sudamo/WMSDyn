namespace CBSys.WinForm
{
    partial class frmK3Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmK3Setting));
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblZTID = new System.Windows.Forms.Label();
            this.txtZTID = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(16, 15);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(82, 15);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "服务器地址";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(112, 11);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(289, 25);
            this.txtUrl.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(195, 112);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblZTID
            // 
            this.lblZTID.AutoSize = true;
            this.lblZTID.Location = new System.Drawing.Point(48, 49);
            this.lblZTID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZTID.Name = "lblZTID";
            this.lblZTID.Size = new System.Drawing.Size(53, 15);
            this.lblZTID.TabIndex = 0;
            this.lblZTID.Text = "帐套ID";
            // 
            // txtZTID
            // 
            this.txtZTID.Location = new System.Drawing.Point(112, 45);
            this.txtZTID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZTID.Name = "txtZTID";
            this.txtZTID.Size = new System.Drawing.Size(289, 25);
            this.txtZTID.TabIndex = 2;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(16, 82);
            this.lblDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(82, 15);
            this.lblDB.TabIndex = 0;
            this.lblDB.Text = "数据库地址";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(111, 79);
            this.txtDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDB.Name = "txtDB";
            this.txtDB.ReadOnly = true;
            this.txtDB.Size = new System.Drawing.Size(291, 25);
            this.txtDB.TabIndex = 2;
            // 
            // frmK3Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtZTID);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblZTID);
            this.Controls.Add(this.lblUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(423, 199);
            this.MinimumSize = new System.Drawing.Size(423, 199);
            this.Name = "frmK3Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "服务器设置";
            this.Load += new System.EventHandler(this.frmK3Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblZTID;
        private System.Windows.Forms.TextBox txtZTID;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox txtDB;
    }
}