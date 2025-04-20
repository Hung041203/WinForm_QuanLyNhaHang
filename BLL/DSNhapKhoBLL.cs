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
    public class DSNhapKhoBLL
    {
        public DataTable Get_ListNhapKho()
        {
            DataTable dt = DSNhapKhoDAL.Get_ListNhapKhoDTO();
            return dt;
        }
        public void Add_NhapKho(NhapKho nhapKho)
        {
            DSNhapKhoDAL.Add_NhapKhoDTO(nhapKho);
        }
        public void Update_InfoNhapKho(NhapKho nhapKho)
        {
            DSNhapKhoDAL.Update_InfoNhapKhoDTO(nhapKho);
        }
        public void Delete_NhapKho(int maNhapKho)
        {
            DSNhapKhoDAL.Delete_NhapKhoDTO(maNhapKho);
        }
    }
}
