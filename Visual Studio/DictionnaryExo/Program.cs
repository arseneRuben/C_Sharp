using ArrayListCours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaryExo
{
    class BankAcount
    {
        public long Num { get; set; }
        public int Solde { get; set; }
        public BankAcount(long num, int s)
        {
            this.Num = num;
            this.Solde = s;
        }
        public override String ToString()
        {
            return "Compte Num: "+this.Num + " Solde : " + this.Solde+" \n";
        }
    }
    class Program
    {
        //1
        public static void Question1()
        {
            Dictionary<Person, BankAcount> dico1 = new Dictionary<Person, BankAcount>();
            dico1.Add(new Student(1, 24, "Dan"), new BankAcount(45421514545, 345));
            dico1.Add(new Student(2, 22, "Alain"), new BankAcount(4542224545, 4343));
            foreach(Person p in dico1.Keys)
            {
                Console.WriteLine(dico1[p]);
            }
        }

        //2
        public static void Question2()
        {
            Dictionary<Person, List<BankAcount>> dico2 = new Dictionary<Person, List<BankAcount>>();
            List<BankAcount> l1 = new List<BankAcount>();
            l1.Add(new BankAcount(45421514545,1345));
            l1.Add(new BankAcount(4542224545, 4343));
            dico2.Add(new Student(1, 24, "Dan"), l1);
            List<BankAcount> l2 = new List<BankAcount>();
            l2.Add(new BankAcount(45671514545, 1452));
            l2.Add(new BankAcount(48882224545, 9343));
           
            dico2.Add(new Student(2, 22, "Alain"), l2);
            foreach (Person p in dico2.Keys)
            {
                Console.WriteLine(p);
                foreach (BankAcount c in dico2[p])
                {
                    Console.WriteLine(c);
                }
            }
        }

        //2
        public static void Question3()
        {
            Dictionary<int, BankAcount> dico1 = new Dictionary<int, BankAcount>();
            Student dan = new Student(1, 24, "Dan");
            dico1.Add(dan.StuNumber, new BankAcount(45421514545, 345));
            Student alan = new Student(2, 22, "Alain");
            dico1.Add(alan.StuNumber, new BankAcount(4542224545, 4343));
            foreach (int p in dico1.Keys)
            {
                Console.WriteLine(dico1[p]);
            }
        }
        static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
        }

    }
}
