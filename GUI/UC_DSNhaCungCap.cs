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
    public partial class UC_DSNhaCungCap: UserControl
    {
        NhaCungCap nhaCungCap = new NhaCungCap();
        DSNhaCungCapBLL dSNhaCungCap = new DSNhaCungCapBLL();
        public UC_DSNhaCungCap()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable dt = dSNhaCungCap.Get_ListNhaCungCap();
            dGV_DSNhaCungCap.DataSource = dt;
        }

        private void dGV_DSNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSNhaCungCap.Rows[e.RowIndex];
                textBox_MaNCC.Text = row.Cells["maNhaCungCapDataGridViewTextBoxColumn"].Value.ToString();
                textBox_TenNCC.Text = row.Cells["tenNhaCungCapDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoDienThoai.Text = row.Cells["soDienThoaiDataGridViewTextBoxColumn"].Value.ToString();
                textBox_Email.Text = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                textBox_DiaChi.Text = row.Cells["diaChiDataGridViewTextBoxColumn"].Value.ToString();

                textBox_TenNCC.Enabled = true;
                textBox_DiaChi.Enabled = true;
                textBox_SoDienThoai.Enabled = true;
                textBox_Email.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaNCC.Clear();
            textBox_TenNCC.Clear();
            textBox_DiaChi.Clear();
            textBox_SoDienThoai.Clear();
            textBox_Email.Clear();


            textBox_TenNCC.Enabled = true;
            textBox_DiaChi.Enabled = true;
            textBox_SoDienThoai.Enabled = true;
            textBox_Email.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhaCungCap.TenNCC = textBox_TenNCC.Text;
            nhaCungCap.DiaChi = textBox_DiaChi.Text;
            nhaCungCap.SoDienThoai = textBox_SoDienThoai.Text;
            nhaCungCap.Email = textBox_Email.Text;

            dSNhaCungCap.Add_NhaCungCap(nhaCungCap);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            textBox_TenNCC.Enabled = true;
            textBox_DiaChi.Enabled = true;
            textBox_SoDienThoai.Enabled = true;
            textBox_Email.Enabled = true;

            nhaCungCap.MaNCC = int.Parse(textBox_MaNCC.Text);
            nhaCungCap.TenNCC = textBox_TenNCC.Text;
            nhaCungCap.DiaChi = textBox_DiaChi.Text;
            nhaCungCap.SoDienThoai = textBox_SoDienThoai.Text;
            nhaCungCap.Email = textBox_Email.Text;

            dSNhaCungCap.Update_InfoNhaCungCap(nhaCungCap);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaNCC != null)
                {
                    int maNCC = Convert.ToInt32(textBox_MaNCC.Text);
                    dSNhaCungCap.Delete_NhaCungCap(maNCC);
                    LoadDataGridView();
                }
            }
        }
    }
}
