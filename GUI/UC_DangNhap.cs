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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class UC_DangNhap: UserControl
    {
        public event EventHandler DangNhapThanhCong;
        public event EventHandler MoTrangDangKy;

        TaiKhoanNhanVien taiKhoan = new TaiKhoanNhanVien();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();


        public UC_DangNhap()
        {
            InitializeComponent();
            this.Load += LoadNhoTaiKhoan;
        }

        private void NhoID()
        {
            DataTable dt = taiKhoanBLL.Get_Info();
            string taiKhoan = textBox_Username.Text;
            int maNhanVien;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TaiKhoan"].ToString() == taiKhoan)
                {
                    maNhanVien = (int)row["MaNhanVien"];
                    Properties.Settings.Default.MaNhanVien = maNhanVien;
                    Properties.Settings.Default.TaiKhoan = taiKhoan;
                    break;
                }
            }
        }

        private void LoadNhoTaiKhoan(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                textBox_Username.Text = Properties.Settings.Default.Username;
                checkBox_SavedUser.Checked = true;
            }
            else
            {
                checkBox_SavedUser.Checked = false;
            }
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            taiKhoan.TaiKhoan = textBox_Username.Text;
            taiKhoan.MatKhau = textBox_Password.Text;

            string getuser = taiKhoanBLL.Check_DangNhap(taiKhoan);

            switch (getuser)
            {
                case "require_taikhoan":
                    MessageBox.Show("Bạn chưa điền tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "require_matkhau":
                    MessageBox.Show("Bạn chưa điền mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "taikhoan_hoac_matkhau_wrong":
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            NhoID();
            if (checkBox_SavedUser.Checked)
            {
                Properties.Settings.Default.Username = textBox_Username.Text;
            }
            else
            {
                Properties.Settings.Default.Username = "";
            }
            Properties.Settings.Default.MaChucVu = taiKhoanBLL.GetMaChucVu(taiKhoan);
            taiKhoanBLL.UpdateConnectionStringBasedOnRole(Properties.Settings.Default.MaChucVu);
            Properties.Settings.Default.Save();

            MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DangNhapThanhCong?.Invoke(this, EventArgs.Empty);
        }

        private void linkLabel_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoTrangDangKy?.Invoke(this, EventArgs.Empty);
        }

        private void checkBox_ShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassWord.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
