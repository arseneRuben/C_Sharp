using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{

    class Test
    {
        private int id;
        private static Student major;
        private static Student second;

        public int Id {
            get { return this.id; } 
        }
        public static Student Major
        {
            get { return Test.major; }
            set { Test.major = value; }
        }
        public static Student Second
        {
            get; set;
        }
        static void Main(string[] args)
        {
            // Test de la classe Student
            /*StudentTest.Major = new Student("Ange Raphael", "ange_raphael@gmail.com", "3453238493", "Sherbook");

            StudentTest.Second = new Student("Bissi Mag", "mag_bissi@gmail.com", "2373238233","Musique", "IUT Bandjoun","Ghomala");

            StudentTest.Major.print();
            StudentTest.Second.print();*/
            // Test de la classe Biblio
            Library biblio = new Library(new List<Book>(), "BANQ");
            Book webSem = new Book("9782100572946", "Dunod", new DateTime(2018, 4, 16), "Fabien Gandon", "Le Web Semantique"
              );
            Book emark = new Book("32002521751667", "Viubert Pratique", new DateTime(2015, 2, 16), "Emilie Courts", "E-marketing & E-commerce"
              );
            Book designPattern = new Book("345548743454", "Dunod",  new DateTime(2010, 12, 10),"Claude Delanoy", "Les design patterns en Java");
            biblio.Add(webSem);
            biblio.Add(emark);
            biblio.Add(designPattern);

            Console.WriteLine("Capacity is {0}", biblio.Books.Capacity);
           foreach(Book b in biblio.Books)
            {
                b.Print();
            }

        }

    }

}


