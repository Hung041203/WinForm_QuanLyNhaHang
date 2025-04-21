using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        private static string defaultConn = @"Data Source=HUNGBUI\PJDBMS;Initial Catalog=RestaurantManagement;Integrated Security=True";

        // Connection string có thể thay đổi khi người dùng đăng nhập thành công
        public static string connectionString = defaultConn;

        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        // Hàm để cập nhật connection string khi đăng nhập
        public static void UpdateConnectionString(string username, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "HUNGBUI\\PJDBMS",
                InitialCatalog = "RestaurantManagement",
                UserID = username,
                Password = password,
                IntegratedSecurity = false
            };

            connectionString = builder.ConnectionString;
        }
    }
}
