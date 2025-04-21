using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_DSLuuTru : UserControl
    {
        TaiKhoanBLL taiKhoan = new TaiKhoanBLL();
        DSLuuTruBLL dSLuuTru = new DSLuuTruBLL();
        DSNguyenLieuBLL dSNguyenLieu = new DSNguyenLieuBLL();
        LuuTru luuTru = new LuuTru();
        public UC_DSLuuTru()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_NhanVien();
            LoadComboBox_NguyenLieu();
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSLuuTru.Get_ListLuuTru();
            dGV_DSLuuTru.DataSource = dt;
        }

        private void LoadComboBox_NhanVien()
        {
            DataTable dt = taiKhoan.Get_Info();
            comboBox_NhanVien.DataSource = dt;
            comboBox_NhanVien.DisplayMember = "TenNhanVien";
            comboBox_NhanVien.ValueMember = "MaNhanVien";
            comboBox_NhanVien.SelectedIndex = -1;
        }
        private void LoadComboBox_NguyenLieu()
        {
            DataTable dt = dSNguyenLieu.Get_ListNguyenLieu();
            comboBox_NguyenLieu.DataSource = dt;
            comboBox_NguyenLieu.DisplayMember = "TenNguyenLieu";
            comboBox_NguyenLieu.ValueMember = "MaNguyenLieu";
            comboBox_NguyenLieu.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaLuuTru.Clear();
            dTP_NgayHetHan.Value = DateTime.Now;
            textBox_SoLuong.Clear();

            comboBox_NhanVien.SelectedIndex = -1;
            comboBox_NhanVien.SelectedItem = null;
            comboBox_NhanVien.Text = "";

            comboBox_NguyenLieu.SelectedIndex = -1;
            comboBox_NguyenLieu.SelectedItem = null;
            comboBox_NguyenLieu.Text = "";

            comboBox_NhanVien.Enabled = true;
            comboBox_NguyenLieu.Enabled = true;
            textBox_SoLuong.Enabled = true;
            dTP_NgayHetHan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luuTru.MaNhanVien = Convert.ToInt32(comboBox_NhanVien.SelectedValue);
            luuTru.MaNguyenLieu = Convert.ToInt32(comboBox_NguyenLieu.SelectedValue); ;
            luuTru.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);
            luuTru.NgayHetHan = Convert.ToDateTime(dTP_NgayHetHan.Value);

            dSLuuTru.Add_LuuTru(luuTru);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luuTru.MaLuuTru = Convert.ToInt32(textBox_MaLuuTru.Text);
            luuTru.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);
            luuTru.NgayHetHan = Convert.ToDateTime(dTP_NgayHetHan.Value);

            dSLuuTru.Update_InfoLuuTru(luuTru);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaLuuTru != null)
                {
                    int maLuuTru = Convert.ToInt32(textBox_MaLuuTru.Text);
                    dSLuuTru.Delete_LuuTru(maLuuTru);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSLuuTru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dGV_DSLuuTru.Rows[e.RowIndex];
            textBox_MaLuuTru.Text = row.Cells["maLuuTruDataGridViewTextBoxColumn"].Value.ToString();
            comboBox_NhanVien.Text = row.Cells["tenNhanVienDataGridViewTextBoxColumn"].Value.ToString();
            comboBox_NguyenLieu.Text = row.Cells["tenNguyenLieuDataGridViewTextBoxColumn"].Value.ToString();
            dTP_NgayHetHan.Value = Convert.ToDateTime(row.Cells["ngayHetHanDataGridViewTextBoxColumn"].Value);
            textBox_SoLuong.Text = row.Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString();

            textBox_SoLuong.Enabled = true;
            dTP_NgayHetHan.Enabled = true;
        }
    }
}
