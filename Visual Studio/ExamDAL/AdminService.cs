using ExamModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDAL
{
    public class AdminService : Service
    {
        public static Admin Login(string name, string password)
        {
            Admin output = null;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT * FROM T_Admin WHERE name=@login AND password=@password";
    
                SqlCommand command = new SqlCommand(request, connection);
                connection.Open();
               
                SqlParameter loginParam = new SqlParameter("@login", SqlDbType.VarChar, 50);
                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 50);

                loginParam.Value = name;
                passwordParam.Value = password;
                command.Parameters.Add(loginParam);
                command.Parameters.Add(passwordParam);

                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    // Displaying Record  
                    output = new Admin((long)sdr["id"],
                                             Convert.ToString(sdr["name"]),
                                            Convert.ToString(sdr["password"])
                                        );
                  

                }
            }

            return output;
        }

      
    }
}
