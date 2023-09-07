using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataToObject
{
    internal class ConnectionString
    {

        private static string ConnString = "";

        //Connection String Variables
        public static string ServerName = "";
        public static string UserName = "";
        public static string Password = "";
        public static bool IntegratedSecurity = false;
        public static string Database = "";

        public static string GetConnectionString()
        {
            //Build and Return ConnectionString

            ConnString = "Data Source=" + ServerName + ";Initial Catalog=" + Database + ";Integrated Security=" + IntegratedSecurity.ToString() + ";User ID=" + UserName + ";Password=" + Password + "";

            return ConnString;
        }

    }
}
