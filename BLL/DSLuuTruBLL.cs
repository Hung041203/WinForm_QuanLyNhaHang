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
    public class DSLuuTruBLL
    {
        public DataTable Get_ListLuuTru()
        {
            DataTable dt = DSLuuTruDAL.Get_ListLuuTruDTO();
            return dt;
        }
        public void Add_LuuTru(LuuTru luuTru)
        {
            DSLuuTruDAL.Add_LuuTruDTO(luuTru);
        }
        public void Update_InfoLuuTru(LuuTru luuTru)
        {
            DSLuuTruDAL.Update_InfoLuuTruDTO(luuTru);
        }
        public void Delete_LuuTru(int maLuuTru)
        {
            DSLuuTruDAL.Delete_LuuTruDTO(maLuuTru);
        }
    }
}
