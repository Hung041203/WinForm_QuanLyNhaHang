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
    public partial class UC_DSXuatKho : UserControl
    {
        int maNguyenLieu;
        XuatKho xuatKho = new XuatKho();
        DSXuatKhoBLL dSXuatKho = new DSXuatKhoBLL();
        TaiKhoanBLL taiKhoan = new TaiKhoanBLL();
        DSLuuTruBLL dSLuuTru = new DSLuuTruBLL();
        DSNguyenLieuBLL dSNguyenLieu = new DSNguyenLieuBLL();
        public UC_DSXuatKho()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_NhanVien();
            LoadComboBox_MaLuuTru();
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSXuatKho.Get_ListXuatKho();
            dGV_DSXuatKho.DataSource = dt;
        }

        private void LoadComboBox_NhanVien()
        {
            DataTable dt = taiKhoan.Get_Info();
            comboBox_NhanVien.DataSource = dt;
            comboBox_NhanVien.DisplayMember = "TenNhanVien";
            comboBox_NhanVien.ValueMember = "MaNhanVien";
            comboBox_NhanVien.SelectedIndex = -1;
        }
        private void LoadComboBox_MaLuuTru()
        {
            DataTable dt = dSLuuTru.Get_ListLuuTru();
            comboBox_MaLuuTru.DataSource = dt;
            comboBox_MaLuuTru.DisplayMember = "MaLuuTru";
            comboBox_MaLuuTru.ValueMember = "MaLuuTru";
            comboBox_MaLuuTru.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuatKho.MaNhanVien = Convert.ToInt32(comboBox_NhanVien.SelectedValue);
            xuatKho.MaNguyenLieu = maNguyenLieu;
            xuatKho.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);
            xuatKho.NguyenNhanXuatKho = textBox_NguyenNhanXuat.Text;
            xuatKho.NgayXuat = Convert.ToDateTime(dTP_NgayXuat.Value);
            xuatKho.MaLuuTru = Convert.ToInt32(comboBox_MaLuuTru.SelectedValue);

            dSXuatKho.Add_XuatKho(xuatKho);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuatKho.MaXuatKho = Convert.ToInt32(textBox_MaXuatKho.Text);
            xuatKho.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);
            xuatKho.NguyenNhanXuatKho = textBox_NguyenNhanXuat.Text;

            dSXuatKho.Update_InfoXuatKho(xuatKho);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaXuatKho != null)
                {
                    int maXuatKho = Convert.ToInt32(textBox_MaXuatKho.Text);
                    dSXuatKho.Delete_XuatKho(maXuatKho);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSXuatKho.Rows[e.RowIndex];
                textBox_MaXuatKho.Text = row.Cells["maXuatKhoDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_NhanVien.Text = row.Cells["tenNhanVienDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenNguyenLieu.Text = row.Cells["tenNguyenLieuDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoLuong.Text = row.Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString();
                dTP_NgayXuat.Value = Convert.ToDateTime(row.Cells["ngayXuatDataGridViewTextBoxColumn"].Value);
                textBox_NguyenNhanXuat.Text = row.Cells["nguyenNhanXuatKhoDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_MaLuuTru.Text = row.Cells["maLuuTruDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaXuatKho.Clear();
            dTP_NgayXuat.Value = DateTime.Now;

            comboBox_NhanVien.SelectedIndex = -1;
            comboBox_NhanVien.SelectedItem = null;
            comboBox_NhanVien.Text = "";

            comboBox_MaLuuTru.SelectedIndex = -1;
            comboBox_MaLuuTru.SelectedItem = null;
            comboBox_MaLuuTru.Text = "";

            textBox_TenNguyenLieu.Clear();
            textBox_SoLuong.Clear();
            textBox_NguyenNhanXuat.Clear();

            comboBox_NhanVien.Enabled = true;
            comboBox_MaLuuTru.Enabled = true;
            textBox_SoLuong.Enabled = true;
            dTP_NgayXuat.Enabled = true;
            textBox_NguyenNhanXuat.Enabled = true;
        }

        private void comboBox_MaLuuTru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_MaLuuTru.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)comboBox_MaLuuTru.SelectedItem;
                textBox_TenNguyenLieu.Text = drv["TenNguyenLieu"].ToString();
                maNguyenLieu = Convert.ToInt32(drv["MaNguyenLieu"]);
            }
            else
            {
                textBox_TenNguyenLieu.Text = "";
            }
        }
    }
}
