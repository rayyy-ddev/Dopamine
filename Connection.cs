using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dopamine
{
    internal class Connection
    {
        public static MySqlConnection con = new MySqlConnection($"server={Properties.Settings.Default.IP};port=3306;username={Properties.Settings.Default.Username};password={Properties.Settings.Default.Password};database={Properties.Settings.Default.Database}");
        //public static MySqlConnection con = new MySqlConnection("server=10.175.212.65;port=3306;username=root;password=;database=dopamine");

        public static void OpenConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    Account.name = "(Гость) (Сервер не найден)";
                }
                
            }
        }

        public static void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Close();
                }
                catch
                {

                }
            }
        }
    }
}
