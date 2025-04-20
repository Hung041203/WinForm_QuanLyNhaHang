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
    public class DSHoaDonDAL : SqlConnectionData
    {
        public static DataTable Get_ListHoaDonDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_HoaDon", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Update_InfoHoaDonDTO(HoaDon hoaDon)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoaDon", hoaDon.MaHoaDon);
            cmd.Parameters.AddWithValue("@MaNhanVien", hoaDon.MaNhanVien);
            cmd.Parameters.AddWithValue("@MaKhachHang", hoaDon.MaKhachHang);
            cmd.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Add_HoaDonDTO(HoaDon hoaDon)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhanVien", hoaDon.MaNhanVien);
            cmd.Parameters.AddWithValue("@MaKhachHang", hoaDon.MaKhachHang);
            cmd.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_HoaDonDTO(int maHD)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoaDon", maHD);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
