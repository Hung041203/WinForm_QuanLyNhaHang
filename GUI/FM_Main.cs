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
    public partial class FM_Main: Form
    {
        UC_TrangChu uC_TrangChu = new UC_TrangChu();
        UC_ThongTinTaiKhoan uC_ThongTinTaiKhoan = new UC_ThongTinTaiKhoan();
        UC_DoiMatKhau uC_DoiMatKhau = new UC_DoiMatKhau();

        public FM_Main()
        {
            InitializeComponent();
            panel_Container.Controls.Add(uC_TrangChu);
            UpdateButtonPermissions(Properties.Settings.Default.MaChucVu);
        }
        private void UpdateButtonPermissions(int maChucVu)
        {
            if (maChucVu == 2)
            {
                button_DSNhanVien.Enabled = false;
                button_NhapKho.Enabled = false;
                button_XuatKho.Enabled = false;
                button_LuuTru.Enabled = false;
                button_DSNguyenLieu.Enabled = false;
                button_DSKhachHang.Enabled = false;
                button_DSKhuyenMai.Enabled = false;
                button_DSNhaCungCap.Enabled = false;
                button_DSChucVu.Enabled = false;
            }
            else if (maChucVu == 3)
            {
                button_DSNhanVien.Enabled = false;
                button_DSHoaDon.Enabled = false;
                button_DSKhachHang.Enabled = false;
                button_DSKhuyenMai.Enabled = false;
                //button_DSNhaCungCap.Enabled = false;
                button_DSChucVu.Enabled = false;
                button_ChiTietHoaDon.Enabled = false;
                button_DSMonAn.Enabled = false;
            }

        }
        private void button_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_ThongTinTaiKhoan);
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DoiMatKhau);
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?","Xác nhận", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                FM_TaiKhoan fm_TaiKhoan = new FM_TaiKhoan();
                fm_TaiKhoan.ShowDialog();
                this.Close();
            }
        }
        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_TrangChu);
        }

        private void button_DSNhanVien_Click(object sender, EventArgs e)
        {
            UC_DSNhanVien uC_DSNhanVien = new UC_DSNhanVien();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSNhanVien);
        }

        private void button_NhaCungCap_Click(object sender, EventArgs e)
        {
            UC_DSNhaCungCap uC_DSNhaCungCap = new UC_DSNhaCungCap();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSNhaCungCap);
        }

        private void button_DSMonAn_Click(object sender, EventArgs e)
        {
            UC_DSMonAn uC_DSMonAn = new UC_DSMonAn();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSMonAn);
        }

        private void button_DSChucVu_Click(object sender, EventArgs e)
        {
            UC_DSChucVu uC_DSChucVu = new UC_DSChucVu();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSChucVu);
        }

        private void button_DSKhachHang_Click(object sender, EventArgs e)
        {
            UC_DSKhachHang uC_DSKhachHang = new UC_DSKhachHang();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSKhachHang);
        }

        private void button_DSNguyenLieu_Click(object sender, EventArgs e)
        {
            UC_DSNguyenLieu uC_DSNguyenLieu = new UC_DSNguyenLieu();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSNguyenLieu);
        }

        private void button_DSKhuyenMai_Click(object sender, EventArgs e)
        {
            UC_DSKhuyenMai uC_DSKhuyenMai = new UC_DSKhuyenMai();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSKhuyenMai);
        }

        private void button_DSHoaDon_Click(object sender, EventArgs e)
        {
            UC_DSHoaDon uC_DSHoaDon = new UC_DSHoaDon();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSHoaDon);
        }

        private void button_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            UC_DSChiTietHoaDon uC_DSChiTietHoaDon = new UC_DSChiTietHoaDon();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSChiTietHoaDon);
        }

        private void button_NhapKho_Click(object sender, EventArgs e)
        {
            UC_DSNhapKho uC_DSNhapKho = new UC_DSNhapKho();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSNhapKho);
        }

        private void button_XuatKho_Click(object sender, EventArgs e)
        {
            UC_DSXuatKho uC_DSXuatKho = new UC_DSXuatKho();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSXuatKho);
        }

        private void button_LuuTru_Click(object sender, EventArgs e)
        {
            UC_DSLuuTru uC_DSLuuTru = new UC_DSLuuTru();
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DSLuuTru);
        }
    }
}
