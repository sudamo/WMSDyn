using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CBSys.WinForm
{
    public partial class frmManage : Form
    {
        #region Fields,Properties,Constructs
        private int _Start;//从数据源的第iStart行开始取数据
        private int _End;//
        private int _PageSize;//每页显示行数        
        private int _PageCount;//页数＝总记录数/每页显示行数
        private int _RecordCount;//总记录数
        private int _CurrentPage;//当前页号
        private Regex reg;
        private DataTable dt;
        private DataTable dtTemp;
        private WMSDyn.ICommon IComm;
        /// <summary>
        /// 
        /// </summary>
        public frmManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManage_Load(object sender, EventArgs e)
        {
            IComm = new WMSDyn.SQL.Common();
            FillCombobox();
            _PageSize = int.Parse(bn_cbxPageSize.ComboBox.SelectedValue.ToString());
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        private void FillCombobox()
        {
            DataTable dtBox;
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
            dr["FName"] = "200";
            dr["FValue"] = "200";
            dtBox.Rows.Add(dr);

            bn_cbxPageSize.ComboBox.DataSource = dtBox;
            bn_cbxPageSize.ComboBox.DisplayMember = "FName";
            bn_cbxPageSize.ComboBox.ValueMember = "FValue";
            bn_cbxPageSize.ComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="pType">Search OR Navi</param>
        private void GetDataSource(string pType)
        {
            if (pType == "Search")//重新加载数据源
            {
                dt = IComm.GetDrawing(txtFileName.Text, null);

                if (dt == null || dt.Rows.Count == 0)
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

            //总记录数
            _RecordCount = dt.Rows.Count;
            //总页数
            _PageCount = (_RecordCount / _PageSize);
            if ((_RecordCount % _PageSize) > 0) _PageCount++;

            //设置分页
            _Start = _PageSize * (_CurrentPage - 1);
            if (_CurrentPage == _PageCount) _End = _RecordCount;
            else _End = _PageSize * _CurrentPage;

            dtTemp = dt.Clone();
            for (int i = _Start; i < _End; i++) dtTemp.ImportRow(dt.Rows[i]);

            bn_txtCurrentPage.Text = _CurrentPage.ToString();
            bn_lblPageCount.Text = _PageCount.ToString() + " 页";
            bn_lblRecordCount.Text = _RecordCount.ToString() + " 行";

            bs1.DataSource = dtTemp;
            bn1.BindingSource = bs1;
            dgv1.DataSource = bs1;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("图纸名称不能为空。");
                return;
            }

            GetDataSource("Search");
        }
        /// <summary>
        /// 锁定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLock_Click(object sender, EventArgs e)
        {
            IComm.LockDrawing(dgv1.CurrentRow.Cells[6].Value.ToString(), true);
        }
        /// <summary>
        /// 解锁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnLock_Click(object sender, EventArgs e)
        {
            IComm.LockDrawing(dgv1.CurrentRow.Cells[6].Value.ToString(), false);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除此图纸吗？", "删除图纸", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtFileName.Text.Trim().Equals(string.Empty))
                    return;

                IComm.DeleteDrawing(dgv1.CurrentRow.Cells[6].Value.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页(&P)")
            {
                if (_CurrentPage - 1 <= 0)
                {
                    MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                    return;
                }
                else
                {
                    _CurrentPage--;
                }
            }
            if (e.ClickedItem.Text == "下一页(&N)")
            {
                if (_CurrentPage + 1 > _PageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                    return;
                }
                else
                {
                    _CurrentPage++;
                }
            }
            if (e.ClickedItem.Text == "跳转到(&G)")
            {
                reg = new Regex(@"^[0-9]*[1-9][0-9]*$");

                if (!reg.IsMatch(bn_txtCurrentPage.Text))
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
            }
            GetDataSource("Navi");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnSearch_Click(null, null);
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
    }
}
