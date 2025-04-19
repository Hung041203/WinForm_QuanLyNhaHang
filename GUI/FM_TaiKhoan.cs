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
    public partial class FM_TaiKhoan: Form
    {
        UC_DangNhap uC_DangNhap = new UC_DangNhap();
        UC_DangKy uC_DangKy = new UC_DangKy();
        public FM_TaiKhoan()
        {
            InitializeComponent();
            panel_Container.Controls.Add(uC_DangNhap);
            uC_DangNhap.DangNhapThanhCong += UC_DangNhap_DangNhapThanhCong;
            uC_DangNhap.MoTrangDangKy += UC_DangNhap_MoTrangDangKy;
            uC_DangKy.QuayLai += UC_DangKy_QuayLai;
        }

        private void UC_DangKy_QuayLai(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DangNhap);
        }

        private void UC_DangNhap_DangNhapThanhCong(object sender, EventArgs e)
        {
            this.Hide();
            FM_Main fm_Main = new FM_Main();
            fm_Main.ShowDialog();
            this.Close();
        }

        private void UC_DangNhap_MoTrangDangKy(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(uC_DangKy);
        }
    }
}
