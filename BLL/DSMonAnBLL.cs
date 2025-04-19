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
    public class DSMonAnBLL
    {
        public DataTable Get_ListMonAn()
        {
            DataTable dt = DSMonAnDAL.Get_ListMonAnDTO();
            return dt;
        }
        public void Add_MonAn(MonAn monAn)
        {
            DSMonAnDAL.Add_MonAnDTO(monAn);
        }
        public void Update_MonAn(MonAn monAn)
        {
            DSMonAnDAL.Update_InfoMonAnDTO(monAn);
        }
        public void Delete_MonAn(int maMA)
        {
            DSMonAnDAL.Delete_MonAnDTO(maMA);
        }
    }

}
