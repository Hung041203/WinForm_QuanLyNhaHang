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
    public partial class UC_DoiMatKhau: UserControl
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public UC_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string currentPass = textBox_CurrentPassword.Text;
            string taiKhoan = Properties.Settings.Default.TaiKhoan;
            string newPass = textBox_NewPassword.Text;
            string cfPass = textBox_ConfirmPass.Text;
            string checkPass = taiKhoanBLL.DoiMatKhau(currentPass, taiKhoan, newPass, cfPass);

            switch (checkPass)
            {
                case "wrong_current_pass":
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "wrong_cfmatkhau":
                    MessageBox.Show("Xác nhận mật khẩu không khớp với mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "require_currentpass":
                    MessageBox.Show("Bạn chưa điền mật khẩu hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "require_cfpass":
                    MessageBox.Show("Bạn chưa điền xác nhận mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "require_newpass":
                    MessageBox.Show("Bạn chưa điền mật khẩu mới", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox_ShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassWord.Checked)
            {
                textBox_CurrentPassword.UseSystemPasswordChar = false;
                textBox_ConfirmPass.UseSystemPasswordChar = false;
                textBox_NewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_CurrentPassword.UseSystemPasswordChar = true;
                textBox_ConfirmPass.UseSystemPasswordChar = true;
                textBox_NewPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
