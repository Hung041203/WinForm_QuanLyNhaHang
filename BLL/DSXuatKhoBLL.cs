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
    public class DSXuatKhoBLL
    {
        public DataTable Get_ListXuatKho()
        {
            DataTable dt = DSXuatKhoDAL.Get_ListXuatKhoDTO();
            return dt;
        }
        public void Add_XuatKho(XuatKho xuatKho)
        {
            DSXuatKhoDAL.Add_XuatKhoDTO(xuatKho);
        }
        public void Update_InfoXuatKho(XuatKho xuatKho)
        {
            DSXuatKhoDAL.Update_InfoXuatKhoDTO(xuatKho);
        }
        public void Delete_XuatKho(int maXuatKho)
        {
            DSXuatKhoDAL.Delete_XuatKhoDTO(maXuatKho);
        }
    }
}
