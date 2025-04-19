using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DTO;

namespace DAL
{
    public class DSNguyenLieuDAL : SqlConnectionData
    {
        public static DataTable Get_ListNguyenLieuDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_NguyenLieu", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Update_InfoNguyenLieuDTO(NguyenLieu nguyenLieu)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinNguyenLieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNguyenLieu", nguyenLieu.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
            cmd.Parameters.AddWithValue("@Gia", nguyenLieu.Gia);
            cmd.Parameters.AddWithValue("@MaNhaCungCap", nguyenLieu.MaNhaCungCap);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Add_NguyenLieuDTO(NguyenLieu nguyenLieu)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemNguyenLieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
            cmd.Parameters.AddWithValue("@Gia", nguyenLieu.Gia);
            cmd.Parameters.AddWithValue("@MaNhaCungCap", nguyenLieu.MaNhaCungCap);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_NguyenLieuDTO(int maNL)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaNguyenLieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNguyenLieu", maNL);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
