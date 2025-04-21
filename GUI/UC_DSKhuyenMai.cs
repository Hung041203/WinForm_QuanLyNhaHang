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
    public partial class UC_DSKhuyenMai : UserControl
    {
        KhuyenMai khuyenMai = new KhuyenMai();
        DSKhuyenMaiBLL dSKhuyenMai = new DSKhuyenMaiBLL();
        DSKhachHangBLL dSKhachHang = new DSKhachHangBLL();
        public UC_DSKhuyenMai()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox_TenKhachHang();
        }
        private void LoadDataGridView()
        {
            DataTable dt = dSKhuyenMai.Get_ListKhuyenMai();
            dGV_DSKhuyenMai.DataSource = dt;
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
            textBox_MaKhuyenMai.Clear();
            textBox_TenKhuyenMai.Clear();
            textBox_TinhTrang.Clear();
            dTP_NgayHetHan.Value = DateTime.Now;
            comboBox_TenKhachHang.SelectedIndex = -1;
            comboBox_TenKhachHang.SelectedItem = null;
            comboBox_TenKhachHang.Text = "";
            checkBox_DaDung.Checked = false;

            textBox_TenKhuyenMai.Enabled = true;
            textBox_TinhTrang.Enabled = true;
            dTP_NgayHetHan.Enabled = true;
            comboBox_TenKhachHang.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            khuyenMai.TenKhuyenMai = textBox_TenKhuyenMai.Text;
            khuyenMai.MaKhachHang = Convert.ToInt32(comboBox_TenKhachHang.SelectedValue);
            khuyenMai.DaDung = checkBox_DaDung.Checked;
            khuyenMai.NgayHetHan = Convert.ToDateTime(dTP_NgayHetHan.Value);

            dSKhuyenMai.Add_KhuyenMai(khuyenMai);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            textBox_TenKhuyenMai.Enabled = true;
            textBox_TinhTrang.Enabled = true;
            dTP_NgayHetHan.Enabled = true;
            comboBox_TenKhachHang.Enabled = true;

            khuyenMai.MaKhuyenMai = Convert.ToInt32(textBox_MaKhuyenMai.Text);
            khuyenMai.TenKhuyenMai = textBox_TenKhuyenMai.Text;
            khuyenMai.MaKhachHang = Convert.ToInt32(comboBox_TenKhachHang.SelectedValue);
            khuyenMai.DaDung = checkBox_DaDung.Checked;
            khuyenMai.NgayHetHan = Convert.ToDateTime(dTP_NgayHetHan.Value);

            dSKhuyenMai.Update_InfoKhuyenMai(khuyenMai);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaKhuyenMai != null)
                {
                    int maNV = Convert.ToInt32(textBox_MaKhuyenMai.Text);
                    dSKhuyenMai.Delete_NguyenLieu(maNV);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSKhuyenMai.Rows[e.RowIndex];
                textBox_MaKhuyenMai.Text = row.Cells["maKhuyenMaiDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenKhuyenMai.Text = row.Cells["tenKhuyenMaiDataGridViewTextBoxColumn"].Value.ToString();
                comboBox_TenKhachHang.Text = row.Cells["tenKhachHangDataGridViewTextBoxColumn"].Value.ToString();
                checkBox_DaDung.Checked = Convert.ToBoolean(row.Cells["daDungDataGridViewCheckBoxColumn"].Value ?? false);
                textBox_TinhTrang.Text = row.Cells["trangThaiDataGridViewTextBoxColumn"].Value.ToString();
                dTP_NgayHetHan.Value = Convert.ToDateTime(row.Cells["ngayHetHanDataGridViewTextBoxColumn"].Value);

                textBox_TenKhuyenMai.Enabled = true;
                textBox_TinhTrang.Enabled = true;
                dTP_NgayHetHan.Enabled = true;
                comboBox_TenKhachHang.Enabled = true;
            }
        }
    }
}
