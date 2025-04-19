using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using DTO;

namespace GUI
{
    public partial class UC_DSMonAn: UserControl
    {
        MonAn monAn = new MonAn();
        DSMonAnBLL dSMonAn = new DSMonAnBLL();
        public UC_DSMonAn()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSMonAn.Get_ListMonAn();
            dGV_DSMonAn.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaMonAn.Clear();
            textBox_TenMonAn.Clear();
            textBox_GiaTien.Clear();
            textBox_SoLuongHienCo.Clear();

            textBox_TenMonAn.Enabled = true;
            textBox_GiaTien.Enabled = true;
            textBox_SoLuongHienCo.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            monAn.TenMonAn = textBox_TenMonAn.Text;
            monAn.Gia = Convert.ToSingle(textBox_GiaTien.Text);
            monAn.SoLuongHienCo = Convert.ToInt32(textBox_SoLuongHienCo.Text);

            dSMonAn.Add_MonAn(monAn);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            textBox_TenMonAn.Enabled = true;
            textBox_GiaTien.Enabled = true;
            textBox_SoLuongHienCo.Enabled = true;

            monAn.MaMonAn = Convert.ToInt32(textBox_MaMonAn.Text);
            monAn.TenMonAn = textBox_TenMonAn.Text;
            monAn.Gia = Convert.ToSingle(textBox_GiaTien.Text);
            monAn.SoLuongHienCo = Convert.ToInt32(textBox_SoLuongHienCo.Text);

            dSMonAn.Update_MonAn(monAn);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaMonAn != null)
                {
                    int maMA = Convert.ToInt32(textBox_MaMonAn.Text);
                    dSMonAn.Delete_MonAn(maMA);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSMonAn.Rows[e.RowIndex];
                textBox_MaMonAn.Text = row.Cells["maMonAnDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenMonAn.Text = row.Cells["tenMonAnDataGridViewTextBoxColumn"].Value.ToString();
                textBox_GiaTien.Text = row.Cells["giaDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoLuongHienCo.Text = row.Cells["soLuongHienCoDataGridViewTextBoxColumn"].Value.ToString();

                textBox_TenMonAn.Enabled = true;
                textBox_GiaTien.Enabled = true;
                textBox_SoLuongHienCo.Enabled = true;
            }
        }
    }
}
