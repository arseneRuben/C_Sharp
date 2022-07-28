using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace ExamDAL
{
    public class Service
    {
        private static string machine = Environment.MachineName;

        public readonly static string connectionString = new SqlConnectionStringBuilder()
        {
            DataSource = machine + "\\SQLEXPRESS",
            InitialCatalog = "DBExamenFinalCSharp",
            IntegratedSecurity = true,
            ConnectTimeout = 10
        }.ConnectionString;
    }
}
