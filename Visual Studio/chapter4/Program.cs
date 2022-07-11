using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
           // Question3();
            Question4();
        }

        static  int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static int GetMax (int a, int b, int c)
        {
            int max = a;
            if (b > GetMax(a, c))
                max = b;
            if (c > GetMax(a, b))
                max = c;
            return max;
        }

        static void Question1()
        {
            Console.WriteLine( 20 == GetMax(-2,3,20) ? "JUSTE" : "FAUX");
            Console.WriteLine(0 == GetMax(-2, -3, 0) ? "JUSTE" : "FAUX");
            Console.WriteLine(2 == GetMax(-2, 2, -20) ? "JUSTE" : "FAUX");
        }

        static void Question2()
        {
            do
            {
                Console.WriteLine("Donner une valeur entiere (-1 pour terminer)");
                int nb = int.Parse(Console.ReadLine());
                if (nb == -1)
                    break;
                else
                {
                    switch (nb % 10)
                    {


                        case 0:
                            Console.WriteLine("ZERO");
                            break;
                        case 1:
                            Console.WriteLine("UN");
                            break;
                        case 2:
                            Console.WriteLine("DEUX");
                            break;
                        case 3:
                            Console.WriteLine("TROIS");
                            break;
                        case 4:
                            Console.WriteLine("QUATRE");
                            break;
                        case 5:
                            Console.WriteLine("CINQ");
                            break;
                        case 6:
                            Console.WriteLine("SIX");
                            break;
                        case 7:
                            Console.WriteLine("SEPT");
                            break;
                        case 8:
                            Console.WriteLine("HUIT");
                            break;
                        case 9:
                            Console.WriteLine("NEUF");
                            break;
                    }
                }
            } while (true);
        }

        static void Occurences( string  word, int  number, out int occurence )
        {
            occurence = 0;
            foreach(char c in word)
            {
                if ((int)(c - '0')== number)
                {
                    occurence++;
                }
              //  Console.WriteLine((int)(c - '0'));
            }
           
        }

     

        static void Question3()
        {
            int res;
            Occurences("J'ai 30 ans et mon epouse 32 ans", 3, out res);
            Console.WriteLine(res==2?"JUSTE":"FAUX");
        }

        static bool BiggerThanNeighbors(int[] tab, int cible)
        {
            if (cible == 0) return tab[cible] > tab[cible + 1];
            if(cible == tab.Length-1) return tab[cible] > tab[cible - 1];
            return tab[cible] > tab[cible + 1] && tab[cible] > tab[cible - 1];
        }

        static void Question4()
        {

            int[] array1 = new int[] { 1, 3, 5,10, 7, 9 };
            Console.WriteLine(BiggerThanNeighbors(array1,3));

        }
    }
}
