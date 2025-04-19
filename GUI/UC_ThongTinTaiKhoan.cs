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
    public partial class UC_ThongTinTaiKhoan: UserControl
    {
        TaiKhoanBLL taiKhoan = new TaiKhoanBLL();
        public UC_ThongTinTaiKhoan()
        {
            InitializeComponent();
            LoadThongTinNhanVien();
        }
        private void LoadThongTinNhanVien()
        {
            DataTable dt = taiKhoan.Get_Info();
            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["MaNhanVien"] == Properties.Settings.Default.MaNhanVien)
                {
                    textBox_MaNhanVien.Text = row["MaNhanVien"].ToString();
                    textBox_TenNhanVien.Text = row["TenNhanVien"].ToString();
                    textBox_ChucVu.Text = row["TenChucVu"].ToString();
                    textBox_DiaChi.Text = row["DiaChi"].ToString();
                    textBox_SoDienThoai.Text = row["SoDienThoai"].ToString();
                    textBox_Email.Text = row["Email"].ToString();
                    break;
                }
            }
        }
    }
}
