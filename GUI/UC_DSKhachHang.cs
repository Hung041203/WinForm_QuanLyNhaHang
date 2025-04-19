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
    public partial class UC_DSKhachHang: UserControl
    {
        KhachHang khachHang = new KhachHang();
        DSKhachHangBLL dSKhachHang = new DSKhachHangBLL();
        public UC_DSKhachHang()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSKhachHang.Get_ListKhachHang();
            dGV_DSKhachHang.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaKhachHang.Clear();
            textBox_TenKhachHang.Clear();
            textBox_DiaChi.Clear();
            textBox_SoDienThoai.Clear();

            textBox_TenKhachHang.Enabled = true;
            textBox_DiaChi.Enabled = true;
            textBox_SoDienThoai.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            khachHang.TenKhachHang = textBox_TenKhachHang.Text;
            khachHang.DiaChi = textBox_DiaChi.Text;
            khachHang.SoDienThoai = textBox_SoDienThoai.Text;

            dSKhachHang.Add_KhachHang(khachHang);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            textBox_TenKhachHang.Enabled = true;
            textBox_DiaChi.Enabled = true;
            textBox_SoDienThoai.Enabled = true;

            khachHang.MaKhachHang = Convert.ToInt32(textBox_MaKhachHang.Text);
            khachHang.TenKhachHang = textBox_TenKhachHang.Text;
            khachHang.DiaChi = textBox_DiaChi.Text;
            khachHang.SoDienThoai = textBox_SoDienThoai.Text;

            dSKhachHang.Update_KhachHang(khachHang);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaKhachHang != null)
                {
                    int maKH = Convert.ToInt32(textBox_MaKhachHang.Text);
                    dSKhachHang.Delete_KhachHang(maKH);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSKhachHang.Rows[e.RowIndex];
                textBox_MaKhachHang.Text = row.Cells["maKhachHangDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenKhachHang.Text = row.Cells["tenKhachHangDataGridViewTextBoxColumn"].Value.ToString();
                textBox_DiaChi.Text = row.Cells["diaChiDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoDienThoai.Text = row.Cells["soDienThoaiDataGridViewTextBoxColumn"].Value.ToString();

                textBox_TenKhachHang.Enabled = true;
                textBox_DiaChi.Enabled = true;
                textBox_SoDienThoai.Enabled = true;
            }
        }
    }
}
