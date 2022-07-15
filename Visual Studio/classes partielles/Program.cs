using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_partielles
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    partial class Employe
        {/// <summary>
        /// Print the employee informations
        /// </summary>
        public void Display()
        {
            String result = "ID: " + this.Id + "\n";
            result += !String.IsNullOrEmpty(this.FirstName) ? " " + this.FirstName : "\n";
            result += !String.IsNullOrEmpty(this.LastName) ? " " + this.LastName : "\n";
            result += !String.IsNullOrEmpty(this.SocialInsuranceNum) ? " " + this.SocialInsuranceNum : "\n";

            result += (this.BirthDay != null) ? " " + this.BirthDay.ToString("MM/dd/yyyy") : "";
            Console.WriteLine(result);
        }

        public Employe(int id, string fn, string ln, DateTime bd, string nas)
        {
            this.Id = id;
            this.FirstName = fn;
            this.LastName = ln;
            this.BirthDay = new DateTime(1989, 2, 4);
            this.SocialInsuranceNum = nas;
        }
    }
}
