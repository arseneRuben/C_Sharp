using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamModel
{
    public class Person
    {
        
        public  long Id { get; set; }
        public string Name { get; set; }
        protected internal Person(long id, string name)
        {
            this.Id = id;
            this.Name = name; 
        }

        protected internal Person(string name)
        {
            
            this.Name = name;
        }
    }

    public class Student : Person
    {
        public int Age { get; set; }
        public DateTime? Birthday { get; set; }
        public Boolean? InternationalStudent { get; set; }

        public Student(long id, string name, int age, DateTime date, Boolean international):base(id, name)
        {
            this.Age = age;
            this.Birthday = date;
            this.InternationalStudent = international;
        }

        public Student( string name, int age, DateTime date, Boolean international) : base( name)
        {
            this.Age = age;
            this.Birthday = date;
            this.InternationalStudent = international;
        }

        public Student(long id, string name, int age) : base(id, name)
        {
            this.Age = age;
            this.Birthday = null;
            this.InternationalStudent = null;
        }
        public Student(long id, string name, int age, DateTime date) : base(id, name)
        {
            this.Age = age;
            this.Birthday = date;
            this.InternationalStudent = null;
        }


        public Student(long id, string name, int age,  Boolean international) : base(id, name)
        {
            this.Age = age;
            this.Birthday = null;
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
