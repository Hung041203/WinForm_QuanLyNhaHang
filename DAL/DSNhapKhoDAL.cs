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
    public class DSNhapKhoDAL : SqlConnectionData
    {
        public static DataTable Get_ListNhapKhoDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_NhapKho", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Add_NhapKhoDTO(NhapKho NhapKho)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemNhapKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhanVien", NhapKho.MaNhanVien);
            cmd.Parameters.AddWithValue("@MaNguyenLieu", NhapKho.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@SoLuong", NhapKho.SoLuong);
            cmd.Parameters.AddWithValue("@NgayNhap", NhapKho.NgayNhap);
            cmd.Parameters.AddWithValue("@SoNgayHetHan", NhapKho.SoNgayHetHan);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_InfoNhapKhoDTO(NhapKho NhapKho)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinNhapKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhapKho", NhapKho.MaNhapKho);
            cmd.Parameters.AddWithValue("@SoLuong", NhapKho.SoLuong);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_NhapKhoDTO(int maNhapKho)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaNhapKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhapKho", maNhapKho);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
