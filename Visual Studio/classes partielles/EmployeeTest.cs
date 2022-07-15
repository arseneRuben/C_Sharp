using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_partielles
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employe emp1 = new Employe(1, "Thomas", "Jefferson", new DateTime(1992, 2, 12), "54875464116e");
            Employe emp2 = new Employe(1, "Hugo", "Bross", new DateTime(1980, 10, 22), "5755464116e");
            emp1.Display();
            emp2.Display();
        }
    }
}
