using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class DSKhachHangBLL
    {
        public DataTable Get_ListKhachHang()
        {
            DataTable dt = DSKhachHangDAL.Get_ListKhachHangDTO();
            return dt;
        }
        public void Add_KhachHang(KhachHang khachHang)
        {
            DSKhachHangDAL.Add_KhachHangDTO(khachHang);
        }
        public void Update_KhachHang(KhachHang khachHang)
        {
            DSKhachHangDAL.Update_InfoKhachHangDTO(khachHang);
        }
        public void Delete_KhachHang(int maKH)
        {
            DSKhachHangDAL.Delete_KhachHangDTO(maKH);
        }
    }
}
