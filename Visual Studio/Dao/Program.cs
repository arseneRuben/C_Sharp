using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class Dal
    {
        static void Main(string[] args)
        {
        }

        public  static void Connect()
        {
            SqlConnection conn = new SqlConnection(connectionString: @"Data Source=your_sql_server_name;Initial Catalog=your_database_name;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            //database operations ...
            conn.Close();
            Console.WriteLine("closed");
        }
    }


}
