using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenement_TeacherSick
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherSick t = new TeacherSick("Alain Hezt", 3);
            Director bonde = new Director(t);
            Student valere = new Student(t);
            Accountant micheline = new Accountant(t);
           
            SchoolReceptionist recpt = new SchoolReceptionist();
            recpt.TeacherSickEvent += micheline.SicknessOccurs;
            recpt.TeacherSickEvent += valere.SicknessOccurs;
            recpt.TeacherSickEvent += bonde.SicknessOccurs;
            recpt.newSickNess(3, t);

           

        }
    }
}
