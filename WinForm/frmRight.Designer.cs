namespace CBSys.WinForm
{
    partial class frmRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRight));
            this.gbxM = new System.Windows.Forms.GroupBox();
            this.gbxU = new System.Windows.Forms.GroupBox();
            this.gbxD = new System.Windows.Forms.GroupBox();
            this.gbxU_RL = new System.Windows.Forms.GroupBox();
            this.rtbM = new System.Windows.Forms.RichTextBox();
            this.rtbU = new System.Windows.Forms.RichTextBox();
            this.rtbD = new System.Windows.Forms.RichTextBox();
            this.rtbU_RL = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxM.SuspendLayout();
            this.gbxU.SuspendLayout();
            this.gbxD.SuspendLayout();
            this.gbxU_RL.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxM
            // 
            this.gbxM.Controls.Add(this.rtbM);
            this.gbxM.Location = new System.Drawing.Point(10, 33);
            this.gbxM.Name = "gbxM";
            this.gbxM.Size = new System.Drawing.Size(462, 100);
            this.gbxM.TabIndex = 1;
            this.gbxM.TabStop = false;
            this.gbxM.Text = "图纸管理";
            // 
            // gbxU
            // 
            this.gbxU.Controls.Add(this.rtbU);
            this.gbxU.Location = new System.Drawing.Point(10, 139);
            this.gbxU.Name = "gbxU";
            this.gbxU.Size = new System.Drawing.Size(462, 100);
            this.gbxU.TabIndex = 2;
            this.gbxU.TabStop = false;
            this.gbxU.Text = "图纸上传";
            // 
            // gbxD
            // 
            this.gbxD.Controls.Add(this.rtbD);
            this.gbxD.Location = new System.Drawing.Point(10, 245);
            this.gbxD.Name = "gbxD";
            this.gbxD.Size = new System.Drawing.Size(462, 100);
            this.gbxD.TabIndex = 1;
            this.gbxD.TabStop = false;
            this.gbxD.Text = "图纸下载";
            // 
            // gbxU_RL
            // 
            this.gbxU_RL.Controls.Add(this.rtbU_RL);
            this.gbxU_RL.Location = new System.Drawing.Point(10, 351);
            this.gbxU_RL.Name = "gbxU_RL";
            this.gbxU_RL.Size = new System.Drawing.Size(462, 100);
            this.gbxU_RL.TabIndex = 3;
            this.gbxU_RL.TabStop = false;
            this.gbxU_RL.Text = "关联关系上传";
            // 
            // rtbM
            // 
            this.rtbM.Location = new System.Drawing.Point(6, 20);
            this.rtbM.Name = "rtbM";
            this.rtbM.ReadOnly = true;
            this.rtbM.Size = new System.Drawing.Size(450, 73);
            this.rtbM.TabIndex = 0;
            this.rtbM.Text = "";
            this.rtbM.Click += new System.EventHandler(this.WriteBox);
            // 
            // rtbU
            // 
            this.rtbU.Location = new System.Drawing.Point(6, 20);
            this.rtbU.Name = "rtbU";
            this.rtbU.ReadOnly = true;
            this.rtbU.Size = new System.Drawing.Size(450, 73);
            this.rtbU.TabIndex = 0;
            this.rtbU.Text = "";
            this.rtbU.Click += new System.EventHandler(this.WriteBox);
            // 
            // rtbD
            // 
            this.rtbD.Location = new System.Drawing.Point(6, 20);
            this.rtbD.Name = "rtbD";
            this.rtbD.ReadOnly = true;
            this.rtbD.Size = new System.Drawing.Size(450, 73);
            this.rtbD.TabIndex = 0;
            this.rtbD.Text = "";
            this.rtbD.Click += new System.EventHandler(this.WriteBox);
            // 
            // rtbU_RL
            // 
            this.rtbU_RL.Location = new System.Drawing.Point(6, 20);
            this.rtbU_RL.Name = "rtbU_RL";
            this.rtbU_RL.ReadOnly = true;
            this.rtbU_RL.Size = new System.Drawing.Size(450, 73);
            this.rtbU_RL.TabIndex = 0;
            this.rtbU_RL.Text = "";
            this.rtbU_RL.Click += new System.EventHandler(this.WriteBox);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxD);
            this.Controls.Add(this.gbxU_RL);
            this.Controls.Add(this.gbxU);
            this.Controls.Add(this.gbxM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmRight";
            this.Text = "权限管理";
            this.Load += new System.EventHandler(this.frmRight_Load);
            this.gbxM.ResumeLayout(false);
            this.gbxU.ResumeLayout(false);
            this.gbxD.ResumeLayout(false);
            this.gbxU_RL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxM;
        private System.Windows.Forms.GroupBox gbxU;
        private System.Windows.Forms.GroupBox gbxD;
        private System.Windows.Forms.GroupBox gbxU_RL;
        private System.Windows.Forms.RichTextBox rtbM;
        private System.Windows.Forms.RichTextBox rtbU;
        private System.Windows.Forms.RichTextBox rtbD;
        private System.Windows.Forms.RichTextBox rtbU_RL;
        private System.Windows.Forms.Button btnSave;
    }
}