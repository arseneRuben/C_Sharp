using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Ange Raphael", "ange_raphael@gmail.com", "3453238493", "Sherbook");
            std1.print();
            Student std2 = new Student("Bissi Mag", "mag_bissi@gmail.com", "2373238233","Musique", "IUT Bandjoun","Ghomala");
            std2.print();
        }
    }
}
