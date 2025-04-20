using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSLuuTruDAL : SqlConnectionData
    {
        public static DataTable Get_ListLuuTruDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_LuuTru", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Add_LuuTruDTO(LuuTru LuuTru)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemLuuTru", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhanVien", LuuTru.MaNhanVien);
            cmd.Parameters.AddWithValue("@MaNguyenLieu", LuuTru.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@SoLuong", LuuTru.SoLuong);
            cmd.Parameters.AddWithValue("@NgayHetHan", LuuTru.NgayHetHan);


            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_InfoLuuTruDTO(LuuTru LuuTru)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinLuuTru", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaLuuTru", LuuTru.MaLuuTru);
            cmd.Parameters.AddWithValue("@SoLuong", LuuTru.SoLuong);
            cmd.Parameters.AddWithValue("@NgayHetHan", LuuTru.NgayHetHan);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_LuuTruDTO(int maLuuTru)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaLuuTru", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaLuuTru", maLuuTru);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
