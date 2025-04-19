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
    public class DSNhaCungCapDAL : SqlConnectionData
    {
        public static DataTable Get_ListNhaCungCapDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhaCungCaps", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Add_NhaCungCapDTO(NhaCungCap nhaCungCap)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemNhaCungCap", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenNhaCungCap", nhaCungCap.TenNCC);
            cmd.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", nhaCungCap.SoDienThoai);
            cmd.Parameters.AddWithValue("@Email", nhaCungCap.Email);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_InfoNhaCungCapDTO(NhaCungCap nhaCungCap)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinNhaCungCap", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhaCungCap", nhaCungCap.MaNCC);
            cmd.Parameters.AddWithValue("@TenNhaCungCap", nhaCungCap.TenNCC);
            cmd.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", nhaCungCap.SoDienThoai);
            cmd.Parameters.AddWithValue("@Email", nhaCungCap.Email);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_NhaCungCapDTO(int maNCC)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaNhaCungCap", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhaCungCap", maNCC);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
