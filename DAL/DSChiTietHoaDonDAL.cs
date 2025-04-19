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
    public class DSChiTietHoaDonDAL : SqlConnectionData
    {
        public static DataTable Get_ListChiTietHoaDonDTO(int maHD)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_LayCTHD_MaHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoaDon", maHD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void Update_InfoChiTietHoaDonDTO(ChiTietHoaDon chiTietHoaDon)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinChiTietHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaChiTietHoaDon", chiTietHoaDon.MaChiTietHoaDon);
            cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Add_ChiTietHoaDonDTO(ChiTietHoaDon chiTietHoaDon)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemChiTietHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDon.MaHoaDon);
            cmd.Parameters.AddWithValue("@MaMonAn", chiTietHoaDon.MaMonAn);
            cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_ChiTietHoaDonDTO(int maCTHD)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaChiTietHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaChiTietHoaDon", maCTHD);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
