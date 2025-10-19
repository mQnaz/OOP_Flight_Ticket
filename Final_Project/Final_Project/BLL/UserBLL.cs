using Final_Project.DAL;
using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BLL
{
    public class UserBLL
    {
        private UserDAL uDAL = new UserDAL();
        public User Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            var u = uDAL.GetUser(username, password);
            if (u == null)
            {
                throw new Exception("Invalid username or password.");
            }
            return u;
        }
        public User Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            try
            {
                var u = uDAL.AddUser(username, password);
                return u;
            }
            catch (Exception ex)
            {
                throw new Exception("Registration failed: " + ex.Message);
            }
        }
    }
}
