using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dopamine
{
    internal class Account
    {
        public static bool hasAccount = false;
        public static string login;
        public static string password;
        public static string name;
        public static int id;
        public static DataTable messengersDT = new DataTable();
    }
}
