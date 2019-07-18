using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CBSys.WinForm.Unity;

namespace CBSys.WinForm
{
    public partial class frmManage : Form
    {
        #region Fields,Properties,Constructs
        /// <summary>
        /// 从数据源的第iStart行开始取数据
        /// </summary>
        private int _Start;
        /// <summary>
        /// 取数据截至行
        /// </summary>
        private int _End;
        /// <summary>
        /// 当前页号（页码）
        /// </summary>
        private int _CurrentPage;
        /// <summary>
        /// 每页显示行数（页长）
        /// </summary>
        private int _PageSize;
        /// <summary>
        /// 页数＝总记录数/每页显示行数（向上取整）
        /// </summary>
        private int _PageCount;
        /// <summary>
        /// 总记录数
        /// </summary>
        private int _RecordCount;
        /// <summary>
        /// Regex
        /// </summary>
        private Regex _reg;
        /// <summary>
        /// 数据源
        /// </summary>
        private DataTable _DataSource;
        /// <summary>
        /// 用于显示的数据
        /// </summary>
        private DataTable _DataTemp;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FromLoad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManage_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }
        #endregion

        /// <summary>
        /// PageSize下拉框数据
        /// </summary>
        private void FillCombobox()
        {
            DataTable dtBox, dtNull;
            DataRow dr;

            dtBox = new DataTable();
            dtBox.Columns.Add("FName");
            dtBox.Columns.Add("FValue");

            dr = dtBox.NewRow();
            dr["FName"] = "25";
            dr["FValue"] = "25";
            dtBox.Rows.Add(dr);

            dr = dtBox.NewRow();
            dr["FName"] = "50";
            dr["FValue"] = "50";
            dtBox.Rows.Add(dr);

            dr = dtBox.NewRow();
            dr["FName"] = "100";
            dr["FValue"] = "100";
            dtBox.Rows.Add(dr);

            dr = dtBox.NewRow();
            dr["FName"] = "1000";
            dr["FValue"] = "1000";
            dtBox.Rows.Add(dr);

            dr = dtBox.NewRow();
            dr["FName"] = "10000";
            dr["FValue"] = "10000";
            dtBox.Rows.Add(dr);

            bn_cbxPageSize.ComboBox.DataSource = dtBox;
            bn_cbxPageSize.ComboBox.DisplayMember = "FName";
            bn_cbxPageSize.ComboBox.ValueMember = "FValue";
            bn_cbxPageSize.ComboBox.SelectedIndex = 0;

            //
            dtNull = new DataTable();
            dtNull.Columns.Add("FName");
            dtNull.Columns.Add("FValue");

            dr = dtNull.NewRow();
            dr["FName"] = "全部";
            dr["FValue"] = "-1";
            dtNull.Rows.Add(dr);

            dr = dtNull.NewRow();
            dr["FName"] = "未关联";
            dr["FValue"] = "0";
            dtNull.Rows.Add(dr);

            dr = dtNull.NewRow();
            dr["FName"] = "已关联";
            dr["FValue"] = "1";
            dtNull.Rows.Add(dr);

            bnTop_cbxIsNull.ComboBox.DataSource = dtNull;
            bnTop_cbxIsNull.ComboBox.DisplayMember = "FName";
            bnTop_cbxIsNull.ComboBox.ValueMember = "FValue";
            bnTop_cbxIsNull.ComboBox.SelectedIndex = 0;

            _PageSize = int.Parse(bn_cbxPageSize.ComboBox.SelectedValue.ToString());
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="pType">Search,ChangePageSize OR Navi</param>
        private void GetDataSource(string pType)
        {
            if (pType == "Search")//重新加载数据源
            {
                _DataSource = CommonFunc.GetDrawing(bnTop_txtName.Text, null, bnTop_cbxIsNull.ComboBox.SelectedIndex, bnTop_txtTrade.Text.Trim());

                if (_DataSource == null || _DataSource.Rows.Count == 0)
                {
                    dgv1.DataSource = null;
                    return;
                }

                _CurrentPage = 1;//当前页数从1开始
            }
            else if (pType == "ChangePageSize")//改变_PageSize，重新计算 _CurrentPage
            {
                if (dgv1.DataSource == null || dgv1.Rows.Count == 0)
                    return;

                _CurrentPage = _Start / _PageSize + 1;
            }

            _RecordCount = _DataSource.Rows.Count;
            _PageCount = (_RecordCount / _PageSize);
            if ((_RecordCount % _PageSize) > 0)
                _PageCount++;

            _Start = _PageSize * (_CurrentPage - 1);
            if (_CurrentPage == _PageCount)
                _End = _RecordCount;
            else
                _End = _PageSize * _CurrentPage;

            _DataTemp = _DataSource.Clone();
            for (int i = _Start; i < _End; i++)
                _DataTemp.ImportRow(_DataSource.Rows[i]);

            bn_txtCurrentPage.Text = _CurrentPage.ToString();
            bn_lblPageCount.Text = _PageCount.ToString() + " 页";
            bn_lblRecordCount.Text = _RecordCount.ToString() + " 行";

            bs1.DataSource = _DataTemp;
            bnBottom.BindingSource = bs1;
            dgv1.DataSource = bs1;

            dgv1.Columns[0].Visible = false;
        }

        /// <summary>
        /// BindingNavigator_ItemClicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnBottom_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (_DataSource == null || _DataSource.Rows.Count == 0 || e.ClickedItem.Tag == null)
                return;

            switch (e.ClickedItem.Tag.ToString())
            {
                case "1":
                    if (_CurrentPage - 1 <= 0)
                    {
                        MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                        return;
                    }
                    else
                    {
                        _CurrentPage--;
                    }
                    break;
                case "2":
                    if (_CurrentPage + 1 > _PageCount)
                    {
                        MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                        return;
                    }
                    else
                    {
                        _CurrentPage++;
                    }
                    break;
                case "3":
                    _reg = new Regex(@"^[0-9]*[1-9][0-9]*$");

                    if (!_reg.IsMatch(bn_txtCurrentPage.Text))
                    {
                        MessageBox.Show("输入的页码格式不正确！");
                        bn_txtCurrentPage.Focus();
                        bn_txtCurrentPage.Text = _PageCount.ToString();
                        bn_txtCurrentPage.Select(0, bn_txtCurrentPage.Text.Length);
                        return;
                    }
                    if (int.Parse(bn_txtCurrentPage.Text) > _PageCount)
                    {
                        MessageBox.Show("跳转页超过了总页数！");
                        return;
                    }
                    _CurrentPage = int.Parse(bn_txtCurrentPage.Text);
                    break;
                default:
                    return;
            }

            //if (e.ClickedItem.Text == "上一页(&P)")
            //{
            //    if (_CurrentPage - 1 <= 0)
            //    {
            //        MessageBox.Show("已经是第一页，请点击“下一页”查看！");
            //        return;
            //    }
            //    else
            //    {
            //        _CurrentPage--;
            //    }
            //}
            //else if (e.ClickedItem.Text == "下一页(&N)")
            //{
            //    if (_CurrentPage + 1 > _PageCount)
            //    {
            //        MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
            //        return;
            //    }
            //    else
            //    {
            //        _CurrentPage++;
            //    }
            //}
            //else if (e.ClickedItem.Text == "跳转到(&G)")
            //{
            //    _reg = new Regex(@"^[0-9]*[1-9][0-9]*$");

            //    if (!_reg.IsMatch(bn_txtCurrentPage.Text))
            //    {
            //        MessageBox.Show("输入的页码格式不正确！");
            //        bn_txtCurrentPage.Focus();
            //        bn_txtCurrentPage.Text = _PageCount.ToString();
            //        bn_txtCurrentPage.Select(0, bn_txtCurrentPage.Text.Length);
            //        return;
            //    }
            //    if (int.Parse(bn_txtCurrentPage.Text) > _PageCount)
            //    {
            //        MessageBox.Show("跳转页超过了总页数！");
            //        return;
            //    }
            //    _CurrentPage = int.Parse(bn_txtCurrentPage.Text);
            //}
            //else
            //    return;

            GetDataSource("Navi");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void bn_cbxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _PageSize = int.Parse(bn_cbxPageSize.ComboBox.SelectedValue.ToString());
                GetDataSource("ChangePageSize");
            }
            catch { }
        }

        private void bnTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag == null)
                return;

            switch (e.ClickedItem.Tag.ToString())
            {
                case "1":
                    Search();
                    break;
                case "2":
                    Edit();
                    break;
                case "3":
                    Delete();
                    break;
                case "4":
                    Lock();
                    break;
                case "5":
                    UnLock();
                    break;
                case "6":
                    Export();
                    break;
            }
        }

        private void Search()
        {
            if (bnTop_txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("图纸名称不能为空。");
                return;
            }

            GetDataSource("Search");

            //bn_lblRLCount.Text = "图纸关联总数量：" + CommonFunc.GetDrawing_RL_Count();
        }
        private void Edit()
        {
            if (dgv1 == null || dgv1.Rows.Count == 0)
                return;

            frmManage_Edit frm = new frmManage_Edit(int.Parse(dgv1.CurrentRow.Cells[0].Value.ToString()), dgv1.CurrentRow.Cells[1].Value.ToString(), dgv1.CurrentRow.Cells[8].Value.ToString());
            frm.ShowDialog();

            if (frm.DialogResult != DialogResult.Cancel)
                Search();
        }
        private void Delete()
        {
            if (dgv1.DataSource == null || dgv1.Rows.Count == 0)
                return;

            if (MessageBox.Show("您确定要删除选中的图纸吗？", "删除图纸", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (dgv1.Rows[i].Selected)
                        CommonFunc.DeleteDrawing(dgv1.Rows[i].Cells[8].Value.ToString());
                }
            }
        }
        private void Lock()
        {
            if (dgv1.DataSource == null || dgv1.Rows.Count == 0)
                return;

            if (MessageBox.Show("您确定要锁定选中的图纸吗？", "锁定图纸", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (dgv1.Rows[i].Selected)
                    {
                        CommonFunc.LockDrawing(dgv1.Rows[i].Cells[8].Value.ToString(), true);
                        dgv1.Rows[i].Cells[6].Value = "是";
                    }
                }
            }
            //CommonFunc.LockDrawing(dgv1.CurrentRow.Cells[7].Value.ToString(), true);

            //dgv1.CurrentRow.Cells[5].Value = "是";
        }
        private void UnLock()
        {
            if (dgv1.DataSource == null || dgv1.Rows.Count == 0)
                return;

            if (MessageBox.Show("您确定要解锁选中的图纸吗？", "解锁图纸", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (dgv1.Rows[i].Selected)
                    {
                        CommonFunc.LockDrawing(dgv1.Rows[i].Cells[8].Value.ToString(), false);
                        dgv1.Rows[i].Cells[6].Value = "否";
                    }
                }
            }
        }
        private void Export()
        {

        }
    }
}
