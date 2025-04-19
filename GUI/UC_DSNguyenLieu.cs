using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class UC_DSNguyenLieu: UserControl
    {
        NguyenLieu nguyenLieu = new NguyenLieu();
        DSNguyenLieuBLL dSNguyenLieu = new DSNguyenLieuBLL();
        DSNhaCungCapBLL dSNhaCungCap = new DSNhaCungCapBLL();
        public UC_DSNguyenLieu()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_TenNCC();
        }
        private void LoadDataGridView()
        {
            DataTable dt = dSNguyenLieu.Get_ListNguyenLieu();
            dGV_DSNguyenLieu.DataSource = dt;
        }
        private void LoadComboBox_TenNCC()
        {
            DataTable dt = dSNhaCungCap.Get_ListNhaCungCap();
            comboBox_TenNCC.DataSource = dt;
            comboBox_TenNCC.DisplayMember = "TenNhaCungCap";
            comboBox_TenNCC.ValueMember = "MaNhaCungCap";
            comboBox_TenNCC.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaNguyenLieu.Clear();
            textBox_TenNguyenLieu.Clear();
            textBox_DonViTinh.Clear();
            textBox_Gia.Clear();
            comboBox_TenNCC.SelectedIndex = -1;
            comboBox_TenNCC.SelectedItem = null;
            comboBox_TenNCC.Text = "";

            textBox_MaNguyenLieu.Enabled = true;
            textBox_DonViTinh.Enabled = true;
            textBox_Gia.Enabled = true;
            comboBox_TenNCC.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nguyenLieu.TenNguyenLieu = textBox_TenNguyenLieu.Text;
            nguyenLieu.MaNhaCungCap = Convert.ToInt32(comboBox_TenNCC.SelectedValue);
            nguyenLieu.DonViTinh = textBox_DonViTinh.Text;
            nguyenLieu.Gia = Convert.ToSingle(textBox_Gia.Text);

            dSNguyenLieu.Add_NguyenLieu(nguyenLieu);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            textBox_MaNguyenLieu.Enabled = true;
            textBox_DonViTinh.Enabled = true;
            textBox_Gia.Enabled = true;
            comboBox_TenNCC.Enabled = true;

            nguyenLieu.MaNguyenLieu = Convert.ToInt32(textBox_MaNguyenLieu.Text);
            nguyenLieu.TenNguyenLieu = textBox_TenNguyenLieu.Text;
            nguyenLieu.MaNhaCungCap = Convert.ToInt32(comboBox_TenNCC.SelectedValue);
            nguyenLieu.DonViTinh = textBox_DonViTinh.Text;
            nguyenLieu.Gia = Convert.ToSingle(textBox_Gia.Text);

            dSNguyenLieu.Update_InfoNguyenLieu(nguyenLieu);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaNguyenLieu != null)
                {
                    int maNV = Convert.ToInt32(textBox_MaNguyenLieu.Text);
                    dSNguyenLieu.Delete_NguyenLieu(maNV);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSNguyenLieu.Rows[e.RowIndex];
                textBox_MaNguyenLieu.Text = row.Cells["maNguyenLieuDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenNguyenLieu.Text = row.Cells["tenNguyenLieuDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_TenNCC.Text = row.Cells["tenNhaCungCapDataGridViewTextBoxColumn"].Value.ToString();
                textBox_Gia.Text = row.Cells["giaDataGridViewTextBoxColumn"].Value.ToString();
                textBox_DonViTinh.Text = row.Cells["donViTinhDataGridViewTextBoxColumn"].Value.ToString();

                textBox_TenNguyenLieu.Enabled = true;
                textBox_DonViTinh.Enabled = true;
                textBox_Gia.Enabled = true;
                comboBox_TenNCC.Enabled = true;
            }
        }
    }
}
