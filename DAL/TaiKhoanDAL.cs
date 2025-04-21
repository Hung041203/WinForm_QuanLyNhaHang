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
    public class TaiKhoanDAL : SqlConnectionData
    {
        public static string Check_DangNhapDTO(TaiKhoanNhanVien taiKhoan)
        {
            string user = null;
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_DangNhap", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

            cmd.Connection = conn;
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    user = rdr.GetInt32(0).ToString();
                    return user;
                }
                rdr.Close();
                conn.Close();
            }
            else
            {
                return "taikhoan_hoac_matkhau_wrong";
            }

            return user;
        }

        public static void Check_DangKyDTO(TaiKhoanNhanVien taiKhoan)
        {
            SqlConnection conn = Connect();
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("proc_DangKy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhanVien", taiKhoan.MaNhanVien);
                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan.TaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Nhân viên này đã có tài khoản!"))
                    throw new Exception("had_user");
                else if (ex.Message.Contains("Tên tài khoản đã được sử dụng!"))
                    throw new Exception("already_in_use");
                else
                    throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable Get_InfoDTO()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_LayThongTin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static string DoiMatKhauDTO(string currentPass, string username, string newPass, string cfPass)
        {
            SqlConnection conn = Connect();
            conn.Open();

            SqlCommand checkCmd = new SqlCommand("proc_LayMatKhau", conn);
            checkCmd.CommandType = CommandType.StoredProcedure;
            checkCmd.Parameters.AddWithValue("@TaiKhoan", username);
            object result = checkCmd.ExecuteScalar();
            string pass = result.ToString();

            if (currentPass != pass)
            {
                return "wrong_current_pass";
            }

            SqlCommand cmd = new SqlCommand("proc_DoiMatKhau", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaiKhoan", username);
            cmd.Parameters.AddWithValue("@MatKhauMoi", newPass);

            cmd.ExecuteNonQuery();
            conn.Close();

            return "success_change_password";
        }

        public static int GetMaChucVuDTO(TaiKhoanNhanVien taiKhoan)
        {
            int maChucVu = -1;
            using (SqlConnection conn = Connect())
            {
                string query = "SELECT nv.MaChucVu FROM TaiKhoanNhanViens tknv " +
                               "JOIN NhanViens nv ON tknv.MaNhanVien = nv.MaNhanVien " +
                               "WHERE tknv.TaiKhoan = @taikhoan";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taikhoan", taiKhoan.TaiKhoan);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maChucVu = reader.GetInt32(0);
                }
            }
            return maChucVu;
        }

    }
}
