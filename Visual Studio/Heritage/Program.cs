using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test
            // We start by creating some courses and their teachers
            Teacher fCapone = new Teacher(1, "Francois Capone");
            Teacher sLapointe = new Teacher(2, "Stephane Lapointe");
            Teacher sDuval = new Teacher(3, "Stephane Duval");

            Course html = new Course(1, "Programmation Web HTML", 10, sLapointe),
                    cPlusPlus = new Course(2, "Introduction à la programmation orientée objets (C++)", 12, fCapone),
                    cSharp = new Course(3, "Programmation dans un environnement graphique (C#)", 14, sDuval),
                java1 = new Course(4, "Programmation orientée objets I (Java I)", 19, sDuval),
              java2 = new Course(5, "Programmation orientée objets II (Java II) ", 10, sLapointe);
            // We continue by creating groupes of students
            Student  urbain = new Student(1, "Urbain"), paolo = new Student(2, "Paolo"),
             arlette = new Student(1, "Arlette"),  arielle = new Student(4, "Arelette");
            // Group creation 
            Group promotion2024 = new Group("Promotion 2024");
            promotion2024.AddStudent(urbain);
            promotion2024.AddStudent(arielle);
            promotion2024.AddCourse(html);
            promotion2024.AddCourse(cSharp);

            Group promotionJava = new Group("Promotion certified Java");
            // deux cours
            promotionJava.AddCourse(java1);
             promotionJava.AddCourse(java2);
             // deux etudiants
             promotionJava.AddStudent(paolo);
             promotionJava.AddStudent(arlette);

            // On va passer a la description de chaque promotion
            promotionJava.print();



        }
    }
}
