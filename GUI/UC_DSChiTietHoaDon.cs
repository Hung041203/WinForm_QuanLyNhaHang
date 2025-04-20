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
    public partial class UC_DSChiTietHoaDon: UserControl
    {
        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
        DSChiTietHoaDonBLL dSChiTietHoaDon = new DSChiTietHoaDonBLL();
        DSHoaDonBLL dSHoaDon = new DSHoaDonBLL();
        DSMonAnBLL dSMonAn = new DSMonAnBLL();
        public UC_DSChiTietHoaDon()
        {
            InitializeComponent();
            LoadComboBox_MaHoaDon();
            LoadComboBox_TenMonAn();
        }

        private void LoadDataGridView()
        {
            if (comboBox_MaHoaDon.SelectedValue != null && comboBox_MaHoaDon.SelectedValue is int)
            {
                int maHD = (int)comboBox_MaHoaDon.SelectedValue;
                DataTable dt = dSChiTietHoaDon.Get_ListChiTietHoaDon(maHD);
                dGV_DSChiTietHoaDon.DataSource = dt;
            }
        }

        private void LoadComboBox_MaHoaDon()
        {
            DataTable dt = dSHoaDon.Get_ListHoaDon();
            comboBox_MaHoaDon.DataSource = dt;
            comboBox_MaHoaDon.DisplayMember = "MaHoaDon";
            comboBox_MaHoaDon.ValueMember = "MaHoaDon";
            comboBox_MaHoaDon.SelectedIndex = -1;
        }
        private void LoadComboBox_TenMonAn()
        {
            DataTable dt = dSMonAn.Get_ListMonAn();
            comboBox_TenMonAn.DataSource = dt;
            comboBox_TenMonAn.DisplayMember = "TenMonAn";
            comboBox_TenMonAn.ValueMember = "MaMonAn";
            comboBox_TenMonAn.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox_MaChiTietHoaDon.Clear();
            textBox_GiaTien.Clear();
            textBox_SoLuong.Clear();
            textBox_ThanhTien.Clear();
            comboBox_MaHoaDon.SelectedIndex = -1;
            comboBox_MaHoaDon.SelectedItem = null;
            comboBox_MaHoaDon.Text = "";

            comboBox_TenMonAn.SelectedIndex = -1;
            comboBox_TenMonAn.SelectedItem = null;
            comboBox_TenMonAn.Text = "";

            textBox_SoLuong.Enabled = true;
            comboBox_TenMonAn.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            chiTietHoaDon.MaHoaDon = Convert.ToInt32(comboBox_MaHoaDon.SelectedValue);
            chiTietHoaDon.MaMonAn = Convert.ToInt32(comboBox_TenMonAn.SelectedValue);
            chiTietHoaDon.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);

            dSChiTietHoaDon.Add_ChiTietHoaDon(chiTietHoaDon);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();

            textBox_SoLuong.Enabled = false;
            comboBox_TenMonAn.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chiTietHoaDon.MaChiTietHoaDon = Convert.ToInt32(textBox_MaChiTietHoaDon.Text);
            chiTietHoaDon.SoLuong = Convert.ToInt32(textBox_SoLuong.Text);

            dSChiTietHoaDon.Update_InfoChiTietHoaDon(chiTietHoaDon);
            MessageBox.Show("Bạn đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (textBox_MaChiTietHoaDon != null)
                {
                    int maCTHD = Convert.ToInt32(textBox_MaChiTietHoaDon.Text);
                    dSChiTietHoaDon.Delete_ChiTietChiTietHoaDon(maCTHD);
                    LoadDataGridView();
                }
            }
        }

        private void dGV_DSChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_DSChiTietHoaDon.Rows[e.RowIndex];

                // Lấy tên món ăn từ cột "TenMonAn"
                string tenMonAn = row.Cells["tenMonAnDataGridViewTextBoxColumn"].Value.ToString();

                // Duyệt qua các item trong ComboBox để tìm đúng tên
                for (int i = 0; i < comboBox_TenMonAn.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)comboBox_TenMonAn.Items[i];
                    Update_GiaTien();
                    if (drv["TenMonAn"].ToString() == tenMonAn)
                    {
                        comboBox_TenMonAn.SelectedIndex = i;
                        Update_GiaTien();
                        break;
                    }
                }

                textBox_MaChiTietHoaDon.Text = row.Cells["maChiTietHoaDonDataGridViewTextBoxColumn"].Value.ToString();
                textBox_SoLuong.Text = row.Cells["soLuongDataGridViewTextBoxColumn"].Value.ToString();
                textBox_ThanhTien.Text = row.Cells["thanhTienDataGridViewTextBoxColumn"].Value.ToString();

                textBox_SoLuong.Enabled = true;
            }
        }

        private void comboBox_TenMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_GiaTien();
        }

        private void Update_GiaTien()
        {
            if (comboBox_TenMonAn.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)comboBox_TenMonAn.SelectedItem;
                textBox_GiaTien.Text = drv["Gia"].ToString();
            }
            else
            {
                textBox_GiaTien.Text = "";
            }
        }

        private void comboBox_MaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_MaHoaDon.SelectedIndex != -1)
            {
                LoadDataGridView();
            }
        }

    }
}
