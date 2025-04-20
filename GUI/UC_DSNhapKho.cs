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
    public partial class UC_DSNhapKho : UserControl
    {
        DSNhapKhoBLL dSNhapKho = new DSNhapKhoBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        DSNguyenLieuBLL dSNguyenLieu = new DSNguyenLieuBLL();
        NhapKho nhapKho = new NhapKho();
        public UC_DSNhapKho()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_NhanVien();
            LoadComboBox_NguyenLieu();
        }

        private void LoadComboBox_NhanVien()
        {
            DataTable dt = taiKhoanBLL.Get_Info();
            comboBox_NhanVien.DataSource = dt;
            comboBox_NhanVien.DisplayMember = "TenNhanVien";
            comboBox_NhanVien.ValueMember = "MaNhanVien";
            comboBox_NhanVien.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSNhapKho.Get_ListNhapKho();
            dGV_DSNhapKho.DataSource = dt;
        }

        private void LoadComboBox_NguyenLieu()
        {
            DataTable dt = dSNguyenLieu.Get_ListNguyenLieu();
            comboBox_NguyenLieu.DataSource = dt;
            comboBox_NguyenLieu.DisplayMember = "TenNguyenLieu";
            comboBox_NguyenLieu.ValueMember = "MaNguyenLieu";
            comboBox_NguyenLieu.SelectedIndex = -1;
        }
        private void Update_GiaTien()
        {
            if (comboBox_NguyenLieu.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)comboBox_NguyenLieu.SelectedItem;
                textBox_GiaTien.Text = drv["Gia"].ToString();
            }
            else
            {
                textBox_GiaTien.Text = "";
            }
        }

        private void dGV_DSNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSNhapKho.Rows[e.RowIndex];
                textBox_MaNhapKho.Text = row.Cells["maNhapKhoDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_NhanVien.Text = row.Cells["tenNhanVienDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoLuong.Text = row.Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString();
                dTP_NgayNhap.Value = Convert.ToDateTime(row.Cells["ngayNhapDataGridViewTextBoxColumn"].Value);
                textBox_SoNgayHetHan.Text = row.Cells["soNgayHetHanDataGridViewTextBoxColumn"].Value.ToString();

                string tenNguyenLieu = row.Cells["tenNguyenLieuDataGridViewTextBoxColumn"].Value.ToString();
                // Duyệt qua các item trong ComboBox để tìm đúng tên
                for (int i = 0; i < comboBox_NguyenLieu.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)comboBox_NguyenLieu.Items[i];
                    Update_GiaTien();
                    if (drv["TenNguyenLieu"].ToString() == tenNguyenLieu)
                    {
                        comboBox_NguyenLieu.SelectedIndex = i;
                        Update_GiaTien();
                        break;
                    }
                }

                textBox_SoLuong.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaNhapKho.Clear();
            dTP_NgayNhap.Value = DateTime.Now;

            comboBox_NhanVien.SelectedIndex = -1;
            comboBox_NhanVien.SelectedItem = null;
            comboBox_NhanVien.Text = "";

            comboBox_NguyenLieu.SelectedIndex = -1;
            comboBox_NguyenLieu.SelectedItem = null;
            comboBox_NguyenLieu.Text = "";

            textBox_SoLuong.Clear();
            textBox_GiaTien.Clear();
            textBox_TongTien.Clear();
            textBox_SoNgayHetHan.Clear();

            comboBox_NhanVien.Enabled = true;
            comboBox_NguyenLieu.Enabled = true;
            textBox_SoLuong.Enabled = true;
            dTP_NgayNhap.Enabled = true;
            textBox_SoNgayHetHan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhapKho.MaNhanVien = Convert.ToInt32(comboBox_NhanVien.SelectedValue);
            nhapKho.MaNguyenLieu = Convert.ToInt32(comboBox_NguyenLieu.SelectedValue);
            nhapKho.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);
            nhapKho.SoNgayHetHan = Convert.ToInt32(textBox_SoNgayHetHan.Text); ;
            nhapKho.NgayNhap = Convert.ToDateTime(dTP_NgayNhap.Value);

            dSNhapKho.Add_NhapKho(nhapKho);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nhapKho.MaNhapKho = Convert.ToInt32(textBox_MaNhapKho.Text);
            nhapKho.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);

            dSNhapKho.Update_InfoNhapKho(nhapKho);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void comboBox_NguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_GiaTien();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaNhapKho != null)
                {
                    int maNhapKho = Convert.ToInt32(textBox_MaNhapKho.Text);
                    dSNhapKho.Delete_NhapKho(maNhapKho);
                    LoadDataGridView();
                }
            }
        }
    }
}
