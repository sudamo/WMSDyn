using System;
using System.Data;
using System.Windows.Forms;
using CBSys.WinForm.Unity;

namespace CBSys.WinForm
{
    public partial class frmManage_RL_Edit : Form
    {
        private int _PID;
        private string _Trade;
        private string _CarSeries;
        private string _CarType;
        private string _SourcePath;
        private int _CategoryID;


        public frmManage_RL_Edit(int pPID, string pTrade, string pCarSeries, string pCarType, string pSourcePath, int pCategoryID)
        {
            _PID = pPID;
            _Trade = pTrade;
            _CarSeries = pCarSeries;
            _CarType = pCarType;
            _SourcePath = pSourcePath;
            _CategoryID = pCategoryID;

            InitializeComponent();
        }

        private void frmManage_RL_Edit_Load(object sender, EventArgs e)
        {
            FillCombobox();

            txtTrade.Text = _Trade;
            txtCarSeries.Text = _CarSeries;
            txtCarType.Text = _CarType;
            txtSourcePath.Text = _SourcePath;

            cbxCategory.SelectedValue = _CategoryID;
        }

        /// <summary>
        /// PageSize下拉框数据
        /// </summary>
        private void FillCombobox()
        {
            DataTable dtBox;
            DataRow dr;

            dtBox = new DataTable();
            dtBox.Columns.Add("FName");
            dtBox.Columns.Add("FValue");

            dr = dtBox.NewRow();
            dr["FName"] = "1";
            dr["FValue"] = "1";
            dtBox.Rows.Add(dr);

            dr = dtBox.NewRow();
            dr["FName"] = "2";
            dr["FValue"] = "2";
            dtBox.Rows.Add(dr);

            dr = dtBox.NewRow();
            dr["FName"] = "3";
            dr["FValue"] = "3";
            dtBox.Rows.Add(dr);

            cbxCategory.DataSource = dtBox;
            cbxCategory.DisplayMember = "FName";
            cbxCategory.ValueMember = "FValue";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Trade = txtTrade.Text.Trim();
            _CarSeries = txtCarSeries.Text.Trim();
            _CarType = txtCarType.Text.Trim();
            _SourcePath = txtSourcePath.Text.Trim();
            _CategoryID = int.Parse(cbxCategory.SelectedValue.ToString());

            CommonFunc.EditDrawing_RL(_PID, _Trade, _CarSeries, _CarType, _SourcePath, _CategoryID);

            MessageBox.Show("保存成功!");
            Close();
        }
    }
}
