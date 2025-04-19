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
    public class DSHoaDonBLL
    {
        public DataTable Get_ListHoaDon()
        {
            DataTable dt = DSHoaDonDAL.Get_ListHoaDonDTO();
            return dt;
        }
        public void Add_HoaDon(HoaDon hoaDon)
        {
            DSHoaDonDAL.Add_HoaDonDTO(hoaDon);
        }
        public void Update_InfoHoaDon(HoaDon hoaDon)
        {
            DSHoaDonDAL.Update_InfoHoaDonDTO(hoaDon);
        }
        public void Delete_HoaDon(int maHD)
        {
            DSHoaDonDAL.Delete_HoaDonDTO(maHD);
        }
    }
}
