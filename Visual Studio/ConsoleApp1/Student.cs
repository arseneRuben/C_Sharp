using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string fullName;
        private string subject;
        private string course;
        private string university;
        private string email;
        private string telephone;
        private static int number = 0;
        public Student(string fullName, string email, string tel)
        {
            this.fullName = fullName;
            this.email = email;
            this.telephone = tel;
            this.subject = null;
            this.course = null;
            this.university = null;
            Student.number++;
        }
        public Student(string fullName, string email, string tel, string course, string univ, string sub)
        {
            this.fullName = fullName;
            this.email = email;
            this.telephone = tel;
            this.subject = sub;
            this.course = course;
            this.university = univ;
            Student.number++;
        }

        public Student(string fullName, string email, string tel, string univ)
        {
            this.fullName = fullName;
            this.email = email;
            this.telephone = tel;
            this.subject = null;
            this.course = null;
            this.university = univ;
            Student.number++;
        }
        
        public void print()
        {
            String result = "Eleve Num: " + number;
            result += !String.IsNullOrEmpty(this.fullName) ? " "+this.fullName : "";
            result += !String.IsNullOrEmpty(this.email) ? " " + this.email : "";
            result += !String.IsNullOrEmpty(this.telephone) ? " " + this.telephone : "";
            result += !String.IsNullOrEmpty(this.course) ? " " + this.course : "";
            result += !String.IsNullOrEmpty(this.university) ? " " + this.university : "";
            result += !String.IsNullOrEmpty(this.subject) ? " " + this.subject : "";
             Console.WriteLine(result);
        }

        public int getEffectif()
        {
            return Student.number;
        }
    }
    class ModifiedStudent
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Subject { get; set; }
        public string Course { get; set; }
        public string University { get; set; }

        private static int number = 0;

        public ModifiedStudent(string fullName, string email, string tel)
        {
            this.FullName = fullName;
            this.Email = email;
            this.Telephone = tel;
            this.Subject = null;
            this.Course = null;
            this.University = null;
            ModifiedStudent.number++;
        }

        public ModifiedStudent(string fullName, string email, string tel, string univ)
        {
            this.FullName = fullName;
            this.Email = email;
            this.Telephone = tel;
            this.Subject = null;
            this.Course = null;
            this.University = univ;
            ModifiedStudent.number++;
        }

        public void print()
        {
            Console.WriteLine("Nom Complet:{0}, Email:{1}, Contact:{2},\n , Sujet:{3}, Cours:{4}, Universite:{5}",
                this.FullName, this.Email, this.Telephone, this.Subject, this.Course, this.University);
        }

        public int getEffectif()
        {
            return ModifiedStudent.number;
        }
    }
}
