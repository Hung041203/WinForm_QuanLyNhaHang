using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSChucVuDAL : SqlConnectionData
    {
        public static DataTable Get_ListChucVuDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVus", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
