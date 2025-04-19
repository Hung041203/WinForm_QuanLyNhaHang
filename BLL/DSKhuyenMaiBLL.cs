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
    public class DSKhuyenMaiBLL
    {
        public DataTable Get_ListKhuyenMai()
        {
            DataTable dt = DSKhuyenMaiDAL.Get_ListKhuyenMaiDTO();
            return dt;
        }
        public void Add_KhuyenMai(KhuyenMai khuyenMai)
        {
            DSKhuyenMaiDAL.Add_KhuyenMaiDTO(khuyenMai);
        }
        public void Update_InfoKhuyenMai(KhuyenMai khuyenMai)
        {
            DSKhuyenMaiDAL.Update_InfoKhuyenMaiDTO(khuyenMai);
        }
        public void Delete_NguyenLieu(int maKM)
        {
            DSKhuyenMaiDAL.Delete_KhuyenMaiDTO(maKM);
        }
    }
}
