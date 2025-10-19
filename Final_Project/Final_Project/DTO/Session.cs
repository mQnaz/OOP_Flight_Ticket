using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Session
    {
        public static string CurrentUsername { get; set; }
        public static string CurrentUserRole { get; set; }

        public static void ClearSession()
        {
            CurrentUsername = null;
            CurrentUserRole = null;
        }
    }
}
