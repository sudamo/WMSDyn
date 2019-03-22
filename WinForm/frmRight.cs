﻿using System;
using System.Windows.Forms;
using CBSys.WMSDyn.Model;

namespace CBSys.WinForm
{
    public partial class frmRight : Form
    {
        /// <summary>
        /// 
        /// </summary>
        WMSDyn.ICommon IComm;

        public frmRight()
        {
            InitializeComponent();
        }

        private void frmRight_Load(object sender, EventArgs e)
        {
            IComm = new WMSDyn.SQL.Common();

            rtbM.Text = UserSetting.Drawing_RInf.Managers;
            rtbU.Text = UserSetting.Drawing_RInf.U_Users;
            rtbD.Text = UserSetting.Drawing_RInf.D_Users;
            rtbU_RL.Text = UserSetting.Drawing_RInf.U_Users2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserSetting.Drawing_RInf.Managers = rtbM.Text;
            UserSetting.Drawing_RInf.U_Users = rtbU.Text;
            UserSetting.Drawing_RInf.D_Users = rtbD.Text;
            UserSetting.Drawing_RInf.U_Users2 = rtbU_RL.Text;

            IComm.ModifyDrawing_RInfo();
        }

        private void WriteBox(object sender, EventArgs e)
        {
            switch (((RichTextBox)sender).Name)
            {
                case "rtbM":
                    rtbM.ReadOnly = false;
                    break;
                case "rtbU":
                    rtbU.ReadOnly = false;
                    break;

                case "rtbD":
                    rtbD.ReadOnly = false;
                    break;

                case "rtbU_RL":
                    rtbU_RL.ReadOnly = false;
                    break;
            }
        }
    }
}