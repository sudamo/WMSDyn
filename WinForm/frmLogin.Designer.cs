namespace CBSys.WinForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.lblPWD = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lklK3Cloud = new System.Windows.Forms.LinkLabel();
            this.chbFC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 27);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "退出(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(60, 130);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 27);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "登陆(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("宋体", 12F);
            this.lblUser.Location = new System.Drawing.Point(3, 60);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 26);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "用户名：";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("宋体", 12F);
            this.txtUser.Location = new System.Drawing.Point(88, 60);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 26);
            this.txtUser.TabIndex = 14;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPWD
            // 
            this.txtPWD.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWD.Location = new System.Drawing.Point(88, 90);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(100, 26);
            this.txtPWD.TabIndex = 15;
            this.txtPWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPWD_KeyPress);
            // 
            // lblPWD
            // 
            this.lblPWD.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPWD.Location = new System.Drawing.Point(3, 90);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(80, 26);
            this.lblPWD.TabIndex = 13;
            this.lblPWD.Text = "密码：";
            this.lblPWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 42);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "登录系统";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lklK3Cloud
            // 
            this.lklK3Cloud.AutoSize = true;
            this.lklK3Cloud.Location = new System.Drawing.Point(10, 167);
            this.lklK3Cloud.Name = "lklK3Cloud";
            this.lklK3Cloud.Size = new System.Drawing.Size(65, 12);
            this.lklK3Cloud.TabIndex = 19;
            this.lklK3Cloud.TabStop = true;
            this.lklK3Cloud.Text = "服务器设置";
            this.lklK3Cloud.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklK3Cloud_LinkClicked);
            // 
            // chbFC
            // 
            this.chbFC.AutoSize = true;
            this.chbFC.Location = new System.Drawing.Point(196, 97);
            this.chbFC.Name = "chbFC";
            this.chbFC.Size = new System.Drawing.Size(48, 16);
            this.chbFC.TabIndex = 20;
            this.chbFC.Text = "分厂";
            this.chbFC.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 186);
            this.ControlBox = false;
            this.Controls.Add(this.chbFC);
            this.Controls.Add(this.lklK3Cloud);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.lblPWD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lklK3Cloud;
        private System.Windows.Forms.CheckBox chbFC;
    }
}