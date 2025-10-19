using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    public class UserDAL : DbHelper
    {
        public User GetUser(string username, string password)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "select * from Users where Username=@username and Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Username = reader.GetString(0),
                        Password = reader.GetString(1),
                        Role = reader.GetString(2)
                    };
                }
                return null;
            }
        }
        public User AddUser(string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, 'Customer')";
            SqlParameter[] prms =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            int result = ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                return new User
                {
                    Username = username,
                    Password = password,
                    Role = "Customer"
                };
            }
            else
            {
                throw new Exception("Failed to add user.");
            }
        }
    }
}
