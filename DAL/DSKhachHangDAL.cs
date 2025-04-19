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
    public class DSKhachHangDAL : SqlConnectionData
    {
        public static DataTable Get_ListKhachHangDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHangs", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Add_KhachHangDTO(KhachHang khachHang)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenKhachHang", khachHang.TenKhachHang);
            cmd.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", khachHang.SoDienThoai);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_InfoKhachHangDTO(KhachHang khachHang)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKhachHang", khachHang.MaKhachHang);
            cmd.Parameters.AddWithValue("@TenKhachHang", khachHang.TenKhachHang);
            cmd.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", khachHang.SoDienThoai);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_KhachHangDTO(int maKH)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKhachHang", maKH);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
