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
    public class DSKhuyenMaiDAL : SqlConnectionData
    {
        public static DataTable Get_ListKhuyenMaiDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_KhuyenMai", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Update_InfoKhuyenMaiDTO(KhuyenMai khuyenMai)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_SuaKhuyenMai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKhuyenMai", khuyenMai.MaKhuyenMai);
            cmd.Parameters.AddWithValue("@TenKhuyenMai", khuyenMai.TenKhuyenMai);
            cmd.Parameters.AddWithValue("@DaDung", khuyenMai.DaDung);
            cmd.Parameters.AddWithValue("@NgayHetHan", khuyenMai.NgayHetHan);
            cmd.Parameters.AddWithValue("@MaKhachHang", khuyenMai.MaKhachHang);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Add_KhuyenMaiDTO(KhuyenMai khuyenMai)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_ThemKhuyenMai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenKhuyenMai", khuyenMai.TenKhuyenMai);
            cmd.Parameters.AddWithValue("@DaDung", khuyenMai.DaDung);
            cmd.Parameters.AddWithValue("@NgayHetHan", khuyenMai.NgayHetHan);
            cmd.Parameters.AddWithValue("@MaKhachHang", khuyenMai.MaKhachHang);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_KhuyenMaiDTO(int maKM)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaKhuyenMai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKhuyenMai", maKM);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
