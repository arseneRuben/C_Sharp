using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamModel
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        protected internal Person(long id, string name)
        {
            this.Id = id;
            this.Name = name; 
        }
    }

    public class Student : Person
    {
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public Boolean InternationalStudent { get; set; }

        public Student(long id, string name, int age, DateTime date, Boolean international):base(id, name)
        {
            this.Age = age;
            this.Birthday = date;
            this.InternationalStudent = international;
        }
        
    }

    public class Admin : Person
    {
        public string Password { get; set; }

        public Admin(long id, string name, string pwd):base(id, name)
        {
            this.Password = pwd;
        }

        public override string ToString()
        {
            return "Id = " + Id + " " + Name + " " + Password;
        }
    }
}
