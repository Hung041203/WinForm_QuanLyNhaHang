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

namespace GUI
{
    public partial class UC_DSHoaDon: UserControl
    {
        HoaDon hoaDon = new HoaDon();
        DSNhanVienBLL dSNhanVien = new DSNhanVienBLL();
        DSKhachHangBLL dSKhachHang = new DSKhachHangBLL();
        DSHoaDonBLL dSHoaDon = new DSHoaDonBLL();
        public UC_DSHoaDon()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_TenNhanVien();
            LoadComboBox_TenKhachHang();
        }
        public void LoadDataGridView()
        {
            DataTable dt = dSHoaDon.Get_ListHoaDon();
            dGV_DSHoaDon.DataSource = dt;
        }

        private void LoadComboBox_TenNhanVien()
        {
            DataTable dt = dSNhanVien.Get_ListNhanVien();
            comboBox_TenNhanVien.DataSource = dt;
            comboBox_TenNhanVien.DisplayMember = "TenNhanVien";
            comboBox_TenNhanVien.ValueMember = "MaNhanVien";
            comboBox_TenNhanVien.SelectedIndex = -1;
        }
        private void LoadComboBox_TenKhachHang()
        {
            DataTable dt = dSKhachHang.Get_ListKhachHang();
            comboBox_TenKhachHang.DataSource = dt;
            comboBox_TenKhachHang.DisplayMember = "TenKhachHang";
            comboBox_TenKhachHang.ValueMember = "MaKhachHang";
            comboBox_TenKhachHang.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaHoaDon.Clear();
            dTP_NgayLap.Value = DateTime.Now;
            textBox_TongTien.Clear();
            comboBox_TenNhanVien.SelectedIndex = -1;
            comboBox_TenNhanVien.SelectedItem = null;
            comboBox_TenNhanVien.Text = "";

            comboBox_TenKhachHang.SelectedIndex = -1;
            comboBox_TenKhachHang.SelectedItem = null;
            comboBox_TenKhachHang.Text = "";

            comboBox_TenNhanVien.Enabled = true;
            comboBox_TenKhachHang.Enabled = true;
            dTP_NgayLap.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hoaDon.MaNhanVien = Convert.ToInt32(comboBox_TenNhanVien.SelectedValue);
            hoaDon.MaKhachHang = Convert.ToInt32(comboBox_TenKhachHang.SelectedValue);
            hoaDon.NgayLap = Convert.ToDateTime(dTP_NgayLap.Value);

            dSHoaDon.Add_HoaDon(hoaDon);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            comboBox_TenNhanVien.Enabled = true;
            comboBox_TenKhachHang.Enabled = true;
            dTP_NgayLap.Enabled = true;

            hoaDon.MaHoaDon = Convert.ToInt32(textBox_MaHoaDon.Text);
            hoaDon.MaNhanVien = Convert.ToInt32(comboBox_TenNhanVien.SelectedValue);
            hoaDon.MaKhachHang = Convert.ToInt32(comboBox_TenKhachHang.SelectedValue);
            hoaDon.NgayLap = Convert.ToDateTime (dTP_NgayLap.Value);

            dSHoaDon.Update_InfoHoaDon(hoaDon);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaHoaDon != null)
                {
                    int maHD = Convert.ToInt32(textBox_MaHoaDon.Text);
                    dSHoaDon.Delete_HoaDon(maHD);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSHoaDon.Rows[e.RowIndex];
                textBox_MaHoaDon.Text = row.Cells["maHoaDonDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_TenKhachHang.Text = row.Cells["tenKhachHangDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_TenNhanVien.Text = row.Cells["tenNhanVienDataGridViewTextBoxColumn"].Value.ToString();
                dTP_NgayLap.Text = row.Cells["ngayLapDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TongTien.Text = row.Cells["tongTienDataGridViewTextBoxColumn"].Value.ToString();

                comboBox_TenNhanVien.Enabled = true;
                comboBox_TenKhachHang.Enabled = true;
                dTP_NgayLap.Enabled = true;
                textBox_TongTien.Enabled = true;
            }
        }
    }
}
