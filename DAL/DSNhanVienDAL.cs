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
    public class DSNhanVienDAL : SqlConnectionData
    {
        public static DataTable Get_ListNhanVienDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_NhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Update_InfoNhanVienDTO(NhanVien nhanVien, int cv)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien);
            cmd.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
            cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", nhanVien.SoDienThoai);
            cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@MaChucVu", cv);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Add_NhanVienDTO(NhanVien nhanVien)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
            cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", nhanVien.SoDienThoai);
            cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@MaChucVu", nhanVien.MaChucVu);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_NhanVienDTO(int maNV)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhanVien", maNV);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
