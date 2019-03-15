namespace CBSys.WinForm
{
    partial class frmUpLoadDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpLoadDrawing));
            this.lblMTL = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtMTL = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMTL
            // 
            this.lblMTL.AutoSize = true;
            this.lblMTL.Location = new System.Drawing.Point(10, 42);
            this.lblMTL.Name = "lblMTL";
            this.lblMTL.Size = new System.Drawing.Size(65, 12);
            this.lblMTL.TabIndex = 0;
            this.lblMTL.Text = "物料编码：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(271, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtMTL
            // 
            this.txtMTL.Location = new System.Drawing.Point(83, 39);
            this.txtMTL.Name = "txtMTL";
            this.txtMTL.Size = new System.Drawing.Size(200, 21);
            this.txtMTL.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(289, 37);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "上传";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(289, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "选择文件";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmUpLoadDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 72);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMTL);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblMTL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 110);
            this.MinimumSize = new System.Drawing.Size(400, 110);
            this.Name = "frmUpLoadDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上传图纸";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMTL;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtMTL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOpen;
    }
}