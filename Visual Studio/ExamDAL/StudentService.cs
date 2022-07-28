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
    class StudentService: Service
    {
        public static int Add(Student std)
        {
            int output = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText =
               "INSERT INTO T_student (name, age,birthday, isInternationalStudent) " +
               "VALUES (  @name,  @age,@birthday, @isInternationalStudent)";

                //SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.Text, 50);
                SqlParameter ageParam = new SqlParameter("@age", SqlDbType.Int);

                SqlParameter birthdayParam = new SqlParameter("@birthday", SqlDbType.DateTime);
                SqlParameter isInternationalStudentParam = new SqlParameter("@isInternationalStudent", SqlDbType.Bit);

               // idParam.Value = std.Id;
                ageParam.Value = std.Age;
                nameParam.Value = std.Name;
                birthdayParam.Value = std.Birthday;
                isInternationalStudentParam.Value = std.InternationalStudent;

                command.Parameters.Add(ageParam);
               // command.Parameters.Add(idParam);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(birthdayParam);
                command.Parameters.Add(isInternationalStudentParam);
               
                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                output =command.ExecuteNonQuery();

            }
            return output;
        }

        public static List<Student> FindBy(in Dictionary<string, string> criteria)
        {
            List<Student> output = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string request = "SELECT * FROM T_Student WHERE ";
                foreach (string key in criteria.Keys)
                {
                    request += key + " = '" + criteria[key] + "' AND ";
                }
                request = request.Remove(request.Length - 4, 4);
                SqlCommand command = new SqlCommand(request, connection);
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    // Displaying Record  
                    output.Add(new Student(
                                                (long)sdr["id"],
                                             (String)sdr["name"],
                                             (int)sdr["age"],
                                             Convert.ToDateTime(sdr["birthday"]),
                                             Convert.ToBoolean(sdr["isInternationalStudent"]))

                                        );

                }
            }

            return output;


        }

        public static void VerifieSiNomDejaPris(string name)
        {
            Dictionary<string, string> critere = new Dictionary<string, string>();
            critere.Add("name", name);
            Console.WriteLine((FindBy(critere)).Count);
        }

        public static void Main(string[] args)
        {
           
            VerifieSiNomDejaPris("Alfred");
            VerifieSiNomDejaPris("Samsung");
        }
    }
}
