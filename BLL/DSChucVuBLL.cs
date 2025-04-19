using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DSChucVuBLL
    {
        public DataTable Get_ListChucVu()
        {
            DataTable dt = DSChucVuDAL.Get_ListChucVuDTO();
            return dt;
        }
    }
}
