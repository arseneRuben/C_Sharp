using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    class Program
    {
        public const double PI = 3.1415926535897931;
        static void Main(string[] args)
        {
            // Question1();
            //Question2();
            //Question3();
        }

        static void Question1()
        {
            Console.Write("Please enter the radius of the circle: ");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Hello,Eh, the perimeter of a circle of radius {0} is {1} and its area is {2}   !", r, 2 * PI * r, PI * Math.Pow(r, 2.0));
        }

        static void Question2()
        {
            Console.Write("Please enter the informations about th compagny ");
            string name, adress, tel, fax;
            Console.Write("Name ");
            name = Console.ReadLine();
            Console.Write("Adress ");
            adress = Console.ReadLine();
            Console.Write("Telephone ");
            tel = Console.ReadLine();
            Console.Write("Fax ");
            fax = Console.ReadLine();
            Console.WriteLine("The compagny {0} has an adress {1} an phone number  {2}, and receive correspondances at fax {3}  ", name, adress, tel, fax);
        }

        static void Question3()
        {
            Console.Write("How many integers do you want to sum? ");
            int nb = int.Parse(Console.ReadLine()), sum = 0;
            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Nombre {0}:", i + 1);
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Le total de ces {0} nombres est de {1}", nb, sum);
        }
    }

}
