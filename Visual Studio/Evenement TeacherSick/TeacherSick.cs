using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenement_TeacherSick
{
    class TeacherSick
    {
        
        public String Teacher;

        public int Days
        {
            get; set;
        }
        
        public TeacherSick( String name)
        {
            this.Days = 0;
            this.Teacher = name;
        }
        public TeacherSick(String name, int d)
        {
            this.Days = d;
            this.Teacher = name;
        }

    }
}
