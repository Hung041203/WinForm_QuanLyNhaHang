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
    public class DSNhanVienBLL
    {
        public DataTable Get_ListNhanVien()
        {
            DataTable dt = DSNhanVienDAL.Get_ListNhanVienDTO();
            return dt;
        }
        public void Add_NhanVien(NhanVien nhanVien)
        {
            DSNhanVienDAL.Add_NhanVienDTO(nhanVien);
        }
        public void Update_InfoNhanVien(NhanVien nhanVien, int cv)
        {
            DSNhanVienDAL.Update_InfoNhanVienDTO(nhanVien, cv);
        }
        public void Delete_NhanVien(int maNV)
        {
            DSNhanVienDAL.Delete_NhanVienDTO(maNV);
        }
    }
}
