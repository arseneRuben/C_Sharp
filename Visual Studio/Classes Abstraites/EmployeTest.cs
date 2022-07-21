using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstraites
{
    class EmployeTest
    {
        static void Main(string[] args)
        {
            Employe simon = new Handler("Alain", "Papineau 3243") { BaseSalary= 343234 };
            Employe patrick = new Handler("Patrick", "6561 Cote vertu"), johan = new Driver("Johan", "7854 Cote des Neige");
            Console.WriteLine(patrick);
            Console.WriteLine(johan);
            Console.WriteLine(simon);
            Computer cp = new Computer();
            USBDisk usb = new USBDisk();
            SmartPhone sm = new SmartPhone();
            cp.ReadData(usb);
            cp.ReadData(sm);


        }

    }
}
