using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstraites
{
    abstract class Employe
    {
        internal protected string Name { get; set; }
        internal protected string Adress { get; set; }
        internal protected float BaseSalary { get; set; }

        public static float fixedSal = 120;
        public Employe(string name, string ad, float sal)
        {
            this.Name = name;
            this.Adress = ad;
            this.BaseSalary = sal;
        }
        public Employe(string name, string ad)
        {
            this.Name = name;
            this.Adress = ad;
            this.BaseSalary = fixedSal;
        }
        abstract public float GetMonthlySalary();

        public override string ToString()
        {
            return base.ToString().Substring( 19) + " " + Name + " " + GetMonthlySalary() + "\n";
        }

    }

    class Driver : Employe
    {
       public Driver(string n, string ad, float sa):base(n,ad, sa)
        {}
        public Driver(string n, string ad) : base(n, ad)
        { }
        public override float GetMonthlySalary()
        {
            return  Employe.fixedSal/12+ 12;
        }

    }

    class Handler : Employe
    {
        public Handler(string n, string ad) : base(n, ad)
        { }
        public override float GetMonthlySalary()
        {
            return Employe.fixedSal/12 + 8;
        }

    }
}
