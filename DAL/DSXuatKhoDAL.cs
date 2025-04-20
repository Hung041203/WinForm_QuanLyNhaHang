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
    public class DSXuatKhoDAL : SqlConnectionData
    {
        public static DataTable Get_ListXuatKhoDTO()
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_XuatKho", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void Add_XuatKhoDTO(XuatKho xuatKho)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_ThemXuatKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNhanVien", xuatKho.MaNhanVien);
            cmd.Parameters.AddWithValue("@MaNguyenLieu", xuatKho.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@SoLuong", xuatKho.SoLuong);
            cmd.Parameters.AddWithValue("@NgayXuat", xuatKho.NgayXuat);
            cmd.Parameters.AddWithValue("@NguyenNhan", xuatKho.NguyenNhanXuatKho);
            cmd.Parameters.AddWithValue("@MaLuuTru", xuatKho.MaLuuTru);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update_InfoXuatKhoDTO(XuatKho xuatKho)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_CapNhatThongTinXuatKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaXuatKho", xuatKho.MaXuatKho);
            cmd.Parameters.AddWithValue("@SoLuong", xuatKho.SoLuong);
            cmd.Parameters.AddWithValue("@NguyenNhan", xuatKho.NguyenNhanXuatKho);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete_XuatKhoDTO(int maXuatKho)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_XoaXuatKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaXuatKho", maXuatKho);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
