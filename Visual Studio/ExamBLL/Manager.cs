using ExamDAL;
using ExamModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBLL
{
    public class Manager
    {
    }

    public static class AdminManager
    {
        public static Admin Login(string login, string password)
        {
            return AdminService.Login(login, password);
        }
    }

    public class StudentManager
    {
        public static int AddStudent(string name, int age, DateTime birthday, bool international)
        {
            return StudentService.Add(new Student(name,age, birthday, international));
        }
    }
}
