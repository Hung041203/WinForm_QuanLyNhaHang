using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public DataTable Get_Info()
        {
            DataTable dt = TaiKhoanDAL.Get_InfoDTO();
            return dt;
        }
        public string Check_DangNhap(TaiKhoanNhanVien taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.TaiKhoan))
            {
                return "require_taikhoan";
            }

            if (string.IsNullOrEmpty(taiKhoan.MatKhau))
            {

                return "require_matkhau";
            }

            string info = TaiKhoanDAL.Check_DangNhapDTO(taiKhoan);
            return info;
        }
        public string Check_DangKy(TaiKhoanNhanVien taiKhoan, string cfmatkhau)
        {
            if (string.IsNullOrEmpty(taiKhoan.TaiKhoan))
            {
                return "require_taikhoan";
            }

            if (string.IsNullOrEmpty(taiKhoan.MatKhau))
            {
                return "require_matkhau";
            }

            if (string.IsNullOrEmpty(cfmatkhau))
            {
                return "require_cfmatkhau";
            }

            if (taiKhoan.MatKhau != cfmatkhau)
            {
                return "wrong_cfmatkhau";
            }

            try
            {
                TaiKhoanDAL.Check_DangKyDTO(taiKhoan);
                return "dang_ky_thanh_cong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DoiMatKhau(string currentPass, string username, string newPass, string cfPass)
        {
            if (string.IsNullOrEmpty(currentPass))
            {
                return "require_currentpass";
            }
            if (string.IsNullOrEmpty(newPass))
            {
                return "require_newpass";
            }
            if (string.IsNullOrEmpty(cfPass))
            {
                return "require_cfpass";
            }
            if (cfPass != newPass)
            {
                return "wrong_cfmatkhau";
            }
            string info = TaiKhoanDAL.DoiMatKhauDTO(currentPass, username, newPass, cfPass);
            return info;
        }
    }
}
