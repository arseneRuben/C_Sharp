using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamModel
{
    public class Person
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
    }

    public class Student : Person
    {
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public bool InternationalStudent { get; set; }

    }

    public class Admin : Person
    {
        public string Password { get; set; }
    }
}
