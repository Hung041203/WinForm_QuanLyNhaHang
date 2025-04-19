using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DSMonAnDAL : SqlConnectionData
    {
        public static DataTable Get_ListMonAnDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MonAns", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Add_MonAnDTO(MonAn monAn)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemMonAn", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
            cmd.Parameters.AddWithValue("@Gia", monAn.Gia);
            cmd.Parameters.AddWithValue("@SoLuong", monAn.SoLuongHienCo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_InfoMonAnDTO(MonAn monAn)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinMonAn", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn);
            cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
            cmd.Parameters.AddWithValue("@Gia", monAn.Gia);
            cmd.Parameters.AddWithValue("@SoLuong", monAn.SoLuongHienCo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_MonAnDTO(int maMA)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaMonAn", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", maMA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
