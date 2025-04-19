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
    public class DSNhaCungCapBLL
    {
        public DataTable Get_ListNhaCungCap()
        {
            DataTable dt = DSNhaCungCapDAL.Get_ListNhaCungCapDTO();
            return dt;
        }
        public void Add_NhaCungCap(NhaCungCap nhaCungCap)
        {
            DSNhaCungCapDAL.Add_NhaCungCapDTO(nhaCungCap);
        }
        public void Update_InfoNhaCungCap(NhaCungCap nhaCungCap)
        {
            DSNhaCungCapDAL.Update_InfoNhaCungCapDTO(nhaCungCap);
        }
        public void Delete_NhaCungCap(int maNCC)
        {
            DSNhaCungCapDAL.Delete_NhaCungCapDTO(maNCC);
        }
    }
}
