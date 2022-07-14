using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    
    class StudentTest
    {
        private static Student major;
        private static Student second;

        public static Student Major
        {
            get; set;
        }
        public static Student Second
        {
            get; set;
        }
        static void Main(string[] args)
        {
            StudentTest.Major = new Student("Ange Raphael", "ange_raphael@gmail.com", "3453238493", "Sherbook");

            StudentTest.Second = new Student("Bissi Mag", "mag_bissi@gmail.com", "2373238233","Musique", "IUT Bandjoun","Ghomala");

            StudentTest.Major.print();
            StudentTest.Second.print();
        }
    }
}
