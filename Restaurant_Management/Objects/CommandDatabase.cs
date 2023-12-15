using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    class CommandDatabase
    {
        public static string queryManagerLogin = "SELECT * FROM manager WHERE username='{0}' and password='{1}'";
        public static string queryStaffLogin = "SELECT * FROM staff WHERE username='{0}' and password='{1}'";
        public static string queryShiftStaff = "SELECT * FROM shift WHERE username='{0}'";
    }
}
