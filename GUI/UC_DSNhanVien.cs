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
using DTO;

namespace GUI
{
    public partial class UC_DSNhanVien : UserControl
    {
        NhanVien nhanVien = new NhanVien();
        DSNhanVienBLL dSNhanVien = new DSNhanVienBLL();
        DSChucVuBLL dSChucVu = new DSChucVuBLL();
        public UC_DSNhanVien()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_ChucVu();
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSNhanVien.Get_ListNhanVien();
            dGV_DSNhanVien.DataSource = dt;
        }

        private void LoadComboBox_ChucVu()
        {
            DataTable dt = dSChucVu.Get_ListChucVu();
            comboBox_ChucVu.DataSource = dt;
            comboBox_ChucVu.DisplayMember = "TenChucVu";
            comboBox_ChucVu.ValueMember = "MaChucVu";
            comboBox_ChucVu.SelectedIndex = -1;
        }

        private void dGV_DSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSNhanVien.Rows[e.RowIndex];
                textBox_MaNhanVien.Text = row.Cells["maNhanVienDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenNhanVien.Text = row.Cells["tenNhanVienDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_ChucVu.Text = row.Cells["tenChucVuDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoDienThoai.Text = row.Cells["soDienThoaiDataGridViewTextBoxColumn"].Value.ToString();
                textBox_Email.Text = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                textBox_DiaChi.Text = row.Cells["diaChiDataGridViewTextBoxColumn"].Value.ToString();

                textBox_TenNhanVien.Enabled = true;
                textBox_DiaChi.Enabled = true;
                textBox_SoDienThoai.Enabled = true;
                textBox_Email.Enabled = true;
                comboBox_ChucVu.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaNhanVien.Clear();
            textBox_TenNhanVien.Clear();
            textBox_DiaChi.Clear();
            textBox_SoDienThoai.Clear();
            textBox_Email.Clear();
            comboBox_ChucVu.SelectedIndex = -1;
            comboBox_ChucVu.SelectedItem = null;
            comboBox_ChucVu.Text = "";

            textBox_TenNhanVien.Enabled = true;
            textBox_DiaChi.Enabled = true;
            textBox_SoDienThoai.Enabled = true;
            textBox_Email.Enabled = true;
            comboBox_ChucVu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhanVien.TenNhanVien = textBox_TenNhanVien.Text;
            nhanVien.MaChucVu = Convert.ToInt32(comboBox_ChucVu.SelectedValue);
            nhanVien.DiaChi = textBox_DiaChi.Text;
            nhanVien.SoDienThoai = textBox_SoDienThoai.Text;
            nhanVien.Email = textBox_Email.Text;

            dSNhanVien.Add_NhanVien(nhanVien);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nhanVien.MaNhanVien = int.Parse(textBox_MaNhanVien.Text);
            nhanVien.TenNhanVien = textBox_TenNhanVien.Text;
            int cv = Convert.ToInt32(comboBox_ChucVu.SelectedValue);
            nhanVien.DiaChi = textBox_DiaChi.Text;
            nhanVien.SoDienThoai = textBox_SoDienThoai.Text;
            nhanVien.Email = textBox_Email.Text;

            dSNhanVien.Update_InfoNhanVien(nhanVien, cv);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaNhanVien != null)
                {
                    int maNV = Convert.ToInt32(textBox_MaNhanVien.Text);
                    dSNhanVien.Delete_NhanVien(maNV);
                    LoadDataGridView();
                }
            }
        }
    }
}