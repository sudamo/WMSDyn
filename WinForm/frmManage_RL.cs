using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CBSys.WinForm.Unity;

namespace CBSys.WinForm
{
    public partial class frmManage_RL : Form
    {
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
        /// 
        /// </summary>
        public frmManage_RL()
        {
            InitializeComponent();
        }

        private void frmManage_RL_Load(object sender, EventArgs e)
        {
            FillCombobox();
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
                _DataSource = CommonFunc.GetDrawing_RL(bnTop_txtTrade.Text.Trim(), bnTop_txtCarSeries.Text.Trim(), bnTop_txtCarType.Text.Trim());

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
                    Add();
                    break;
                case "3":
                    Edit();
                    break;
                case "4":
                    Clear();
                    break;
                case "5":
                    Delete();
                    break;
            }
        }

        private void Search()
        {
            if (bnTop_txtTrade.Text.Trim().Equals(string.Empty) && bnTop_txtCarSeries.Text.Trim().Equals(string.Empty) && bnTop_txtCarType.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("筛选条件不能都为空。");
                return;
            }

            GetDataSource("Search");
            bn_lblRLCount.Text = "图纸关联总数量：" + CommonFunc.GetDrawing_RL_Count();
        }
        private void Add()
        {
            frmManage_RL_Edit frm = new frmManage_RL_Edit("Add", 0, "", "", "", "", 1);
            frm.ShowDialog();

            if (frm.DialogResult != DialogResult.Cancel)
                Search();
        }
        private void Edit()
        {
            if (dgv1 == null || dgv1.Rows.Count == 0)
                return;

            int iPid = int.Parse(dgv1.CurrentRow.Cells[0].Value.ToString());
            string strTrade = dgv1.CurrentRow.Cells[1].Value.ToString();
            string strCarSeries = dgv1.CurrentRow.Cells[2].Value.ToString();
            string strCarType = dgv1.CurrentRow.Cells[3].Value.ToString();
            string strSourcePath = dgv1.CurrentRow.Cells[5].Value.ToString();
            int iCategoryID = int.Parse(dgv1.CurrentRow.Cells[4].Value.ToString());

            frmManage_RL_Edit frm = new frmManage_RL_Edit("Edit", iPid, strTrade, strCarSeries, strCarType, strSourcePath, iCategoryID);
            frm.ShowDialog();

            if (frm.DialogResult != DialogResult.Cancel)
                Search();
        }
        private void Clear()
        {
            if (MessageBox.Show("您确定要清除无效的图纸关联关系吗？", "清除无效关联关系", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CommonFunc.ClearDrawing_RL();
            }
        }
        private void Delete()
        {
            if (dgv1.DataSource == null || dgv1.Rows.Count == 0)
                return;

            if (MessageBox.Show("您确定要删除选中的关联关系吗？", "删除关联关系", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (dgv1.Rows[i].Selected)
                        CommonFunc.DeleteDrawing_RL(int.Parse(dgv1.Rows[i].Cells[0].Value.ToString()));
                }
            }
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

        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv1 == null || dgv1.Rows.Count == 0)
                return;

            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {
                Point _Point = dgv1.PointToClient(Cursor.Position);
                cms1.Show(dgv1, _Point);
            }
        }

        private void cms1_Copy_Click(object sender, EventArgs e)
        {
            string strTrade = dgv1.CurrentRow.Cells[1].Value.ToString();
            string strCarSeries = dgv1.CurrentRow.Cells[2].Value.ToString();
            string strCarType = dgv1.CurrentRow.Cells[3].Value.ToString();
            string strSourcePath = dgv1.CurrentRow.Cells[5].Value.ToString();
            int iCategoryID = int.Parse(dgv1.CurrentRow.Cells[4].Value.ToString());

            frmManage_RL_Edit frm = new frmManage_RL_Edit("Add", 0, strTrade, strCarSeries, strCarType, strSourcePath, iCategoryID);
            frm.ShowDialog();

            if (frm.DialogResult != DialogResult.Cancel)
                Search();
        }
    }
}
