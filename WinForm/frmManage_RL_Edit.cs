using System;
using System.Data;
using System.Windows.Forms;
using CBSys.WinForm.Unity;

namespace CBSys.WinForm
{
    /// <summary>
    /// 编辑图纸关联关系
    /// </summary>
    public partial class frmManage_RL_Edit : Form
    {
        #region Fields,Constructs
        private string _FormType;
        private int _PID;
        private string _Trade;
        private string _CarSeries;
        private string _CarType;
        private string _SourcePath;
        private int _CategoryID;

        public frmManage_RL_Edit(string pFormType, int pPID, string pTrade, string pCarSeries, string pCarType, string pSourcePath, int pCategoryID)
        {
            _FormType = pFormType;
            _PID = pPID;
            _Trade = pTrade;
            _CarSeries = pCarSeries;
            _CarType = pCarType;
            _SourcePath = pSourcePath;
            _CategoryID = pCategoryID;

            InitializeComponent();
        }
        #endregion

        private void frmManage_RL_Edit_Load(object sender, EventArgs e)
        {
            FillCombobox();

            if (_FormType == "Add")
            {
                Text = "图纸关联关系-新增";
            }
            else if (_FormType == "Edit")
            {
                Text = "图纸关联关系-编辑";
            }

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

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSourcePath.Text.Trim() == string.Empty || txtTrade.Text.Trim() == string.Empty || txtCarSeries.Text.Trim() == string.Empty || txtCarType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("还有信息未填写，请检查。");
                return;
            }

            _SourcePath = txtSourcePath.Text.Trim();
            _CategoryID = int.Parse(cbxCategory.SelectedValue.ToString());

            if (_FormType == "Add")
            {
                _Trade = txtTrade.Text.Trim();
                _CarSeries = txtCarSeries.Text.Trim();
                _CarType = txtCarType.Text.Trim();

                //先判断唯一性
                if (CommonFunc.CheckDrawing_RL_UK(_Trade, _CarSeries, _CarType))
                    CommonFunc.EditDrawing_RL("Add", 0, _Trade, _CarSeries, _CarType, _SourcePath, _CategoryID);
                else
                {
                    MessageBox.Show("数据库中已经存在此商品名、车型、车型：[" + _Trade + "|" + _CarSeries + "|" + _CarType + "]");
                    return;
                }
            }
            else
            {
                if (!(_Trade == txtTrade.Text.Trim() && _CarSeries == txtCarSeries.Text.Trim() && _CarType == txtCarType.Text.Trim()))
                {
                    _Trade = txtTrade.Text.Trim();
                    _CarSeries = txtCarSeries.Text.Trim();
                    _CarType = txtCarType.Text.Trim();

                    //先判断唯一性
                    if (CommonFunc.CheckDrawing_RL_UK(_Trade, _CarSeries, _CarType))
                        CommonFunc.EditDrawing_RL("Edit", _PID, _Trade, _CarSeries, _CarType, _SourcePath, _CategoryID);
                    else
                    {
                        MessageBox.Show("数据库中已经存在此商品名、车型、车型：[" + _Trade + "|" + _CarSeries + "|" + _CarType + "]");
                        return;
                    }
                }
                else
                    CommonFunc.EditDrawing_RL("Edit", _PID, _Trade, _CarSeries, _CarType, _SourcePath, _CategoryID);

                MessageBox.Show("保存成功!");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {            
            switch(cbxCategory.SelectedIndex)
            {
                case 0:
                    lbl_Catetory_Tip.Text = "一码一图";
                    break;
                case 1:
                    lbl_Catetory_Tip.Text = "一码两图,同时打开";
                    break;
                case 2:
                    lbl_Catetory_Tip.Text = "一码两图,打开其一";
                    break;
            }
        }
    }
}
