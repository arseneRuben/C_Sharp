using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExos
{
    class Program
    {
        static List<int> GetPrimes(int start, int end)
        {
            List<int> premiers = new List<int>();
            if(end >= start)
            {
                for (int i=start; i<=end; i++)
                {
                    if (NbDiv(i) <= 1)
                    {
                        premiers.Add(i);
                    }
                }
            }
            return premiers;
            
        }
        // Return the number of divisor of n great than 1
        private static int NbDiv(int n)
        {
            int nbdiv = 0;
            if (n > 1)
            {
                nbdiv = 1;
                for(int i=2; i<= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        nbdiv++;
                    }
                }
            }
          
            return nbdiv;
        }
            static void Main(string[] args)
        {
            Console.Write("Start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End = ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Liste des nombres premiers entre {0} et {1}", start, end);
            foreach(int d in GetPrimes(start, end))
            {
                Console.WriteLine(d);
            }
        }
    }
}
