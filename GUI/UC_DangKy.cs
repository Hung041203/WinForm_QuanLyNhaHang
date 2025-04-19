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
using System.Security.Cryptography.X509Certificates;

namespace GUI
{
    public partial class UC_DangKy: UserControl
    {
        public event EventHandler QuayLai;
        TaiKhoanNhanVien taiKhoan = new TaiKhoanNhanVien();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public UC_DangKy()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            DataTable dt = taiKhoanBLL.Get_Info();
            comboBox_ID.DataSource = dt;
            comboBox_ID.DisplayMember = "TenNhanVien";
            comboBox_ID.ValueMember = "MaNhanVien";
            comboBox_ID.SelectedIndex = -1;
        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)comboBox_ID.SelectedItem;
                textBox_Position.Text = drv["TenChucVu"].ToString();
            }
            else
            {
                textBox_Position.Text = "";
            }
        }

        private void checkBox_ShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassWord.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
                textBox_ConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
                textBox_ConfirmPass.UseSystemPasswordChar = true;

            }
        }

        private void button_QuayLai_Click(object sender, EventArgs e)
        {
            QuayLai?.Invoke(this, EventArgs.Empty);
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            taiKhoan.MaNhanVien = Convert.ToInt32(comboBox_ID.SelectedValue);
            taiKhoan.TaiKhoan = textBox_Username.Text;
            taiKhoan.MatKhau = textBox_Password.Text;
            string cfmatKhau = textBox_ConfirmPass.Text;
            string register = taiKhoanBLL.Check_DangKy(taiKhoan, cfmatKhau);

            switch (register)
            {
                case "require_taikhoan":
                    MessageBox.Show("Bạn chưa điền tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "require_matkhau":
                    MessageBox.Show("Bạn chưa điền mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "require_cfmatkhau":
                    MessageBox.Show("Bạn chưa điền xác nhận mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "wrong_cfmatkhau":
                    MessageBox.Show("Xác nhận mật khẩu không khớp với mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "had_user":
                    MessageBox.Show("ID này đã có tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "already_in_use":
                    MessageBox.Show("Tài khoản đã có người khác sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            MessageBox.Show("Bạn đã đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
