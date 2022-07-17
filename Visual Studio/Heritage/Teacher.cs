using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    /// This class is used to describe each teacher
    /// </summary>
    class Teacher : Person
    {
        public Teacher(int id, String name, Group p)
           : base(id, name, p)
        { }
        public Teacher(int id, String name)
          : base(id, name, null)
        { }
    }
}
