using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DSChiTietHoaDonBLL
    {
        public DataTable Get_ListChiTietHoaDon(int maHD)
        {
            DataTable dt = DSChiTietHoaDonDAL.Get_ListChiTietHoaDonDTO(maHD);
            return dt;
        }
        public void Add_ChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            DSChiTietHoaDonDAL.Add_ChiTietHoaDonDTO(chiTietHoaDon);
        }
        public void Update_InfoChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            DSChiTietHoaDonDAL.Update_InfoChiTietHoaDonDTO(chiTietHoaDon);
        }
        public void Delete_ChiTietChiTietHoaDon(int maCTMA)
        {
            DSChiTietHoaDonDAL.Delete_ChiTietHoaDonDTO(maCTMA);
        }
    }
}
