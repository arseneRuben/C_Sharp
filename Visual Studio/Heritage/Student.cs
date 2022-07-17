using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Student: Person
    {
      public Student(int id, String name, Group p) 
            : base(id, name, p)
      {}

      public Student(int id, String name)
           : base(id, name, null)
        { }
    }
}
