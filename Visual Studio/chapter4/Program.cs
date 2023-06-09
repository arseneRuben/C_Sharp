﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    class Program
    {
        private static  int[] array1 = new int[] { 1, 3, 5, 10, 7, 9 };
        private static float[]  array2 = new float[] { -11.01f, 3.7f, 100.33f, 1.4f, 23, -5.09f, 2 };

    static void Main(string[] args)
        {
            //Question1();
            //Question2();
            // Question3();
            //Question4();
            //Question5();
            Question6();
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
        {   // Si on est au premier element, je retourne le resuleta de la comparaison avec le voisin droit
            if (cible == 0) return tab[cible] > tab[cible + 1];
            // Si on est au dernier element, je retourne le resuleta de la comparaison avec le voisin gauche
            if (cible == tab.Length-1) return tab[cible] > tab[cible - 1];
            // Dans tout autre cas, le retourne le resultat de la comparaison avec les deux voisins
            return tab[cible] > tab[cible + 1] && tab[cible] > tab[cible - 1];
        }
        // Ici j'ai pas fais explicitement usage des IF ELSE, 
        static void Question4()
        {

            Console.WriteLine(BiggerThanNeighbors(array1,3));

        }

        static void Question5()
        {
            //Methode 1
            Console.WriteLine("Methode 1\n");
            Print(array1);
            sort1(array1);
            //Methode 2
            Console.WriteLine("Methode 2\n");
            array1 = new int[] { 1, 3, 5, 10, 7, 9 };
            Print(array1);
            sort2(array1);
        }
        /// <summary>
        /// copies the values of the array from the beginning to the penultimate element
        /// </summary>
        /// <param name="tab"></param>
       
        /// <returns></returns>
        static int[] partialCopy(int[] tab)
        {
            int[] copy = new int[tab.Length - 1];
            for (int j = 0; j < tab.Length -1; j++)
            {
                copy[j] = tab[j];
            }
            return copy;
        }

        /// <summary>
        /// finds the index of largest element of the array from index p to the last
        /// </summary>
        /// <param name="tab">The array</param>
        /// <param name="p">stating index</param>
        /// <returns>index of largest</returns>
        static int biggerElmt(in int[] tab,in int p)
        {
            int bigger = 0;
            for(int i=0; i<=tab.Length-p-1; i++)
            {
                if (tab[i] > tab[bigger])
                    bigger = i;
            }
            return bigger;
        }

        /// <summary>
        /// finds the index of largest element of the array
        /// </summary>
        /// <param name="tab">The array</param>
        
        /// <returns>index of largest</returns>
        static int biggerElmt(in int[] tab)
        {
            int bigger = 0;
            for (int i = 0; i <= tab.Length  - 1; i++)
            {
                if (tab[i] > tab[bigger])
                    bigger = i;
            }
            return bigger;
        }
        /// <summary>
        /// sorts the array in ascending order by searching each time for the index of the largest element and swapping it with the last
        /// </summary>
        /// <param name="tab">array to sort</param>
        /// <returns>array sorted</returns>
        static int[] sort1(int[] tab)
        {
            int max;
            for (int i=0; i<tab.Length; i++)
            {
                max = biggerElmt(in tab, in i);
                //Console.WriteLine("I= {0} , Max= {1} \n ",i,tab[max]);
                Permut(in tab, max, tab.Length - 1-i);
                Print(tab);
            }
            return tab;
        }

        static int[] sort2(int[] tab)
        {
            int[] result = new int[tab.Length];
            for (int i = 0; i < result.Length; i++)
            {
                int bigger = biggerElmt(tab);
                result[result.Length - 1 - i] = tab[bigger];
                Permut(in tab, bigger, tab.Length - 1);
                tab = partialCopy(tab);
                Print(result);
            }          
            return result;
        }

        static void Print(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(" {0} ", tab[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// swaps the values of the array tab positioned at indices a and b
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Permut(in int[] tab, int a, int b)
        {
            /*tab[a] = tab[a] + tab[b];
            tab[b] = tab[a] - tab[b];
            tab[a] = tab[a] - tab[b];*/
            int temp = tab[a];
            tab[a] = tab[b];
            tab[b] = temp;
        }

        static void MinMaxArray(float[] data, out float min, out float max)
        {
            min = data[0];
            max = data[0];
            foreach(int n in data)
            {
                if (max < n)
                    max = n;
                if (min > n)
                    min = n;
            }
        }

        static void Question6()
        {
            float min, max;
            MinMaxArray(array2, out min,out max);
            Console.WriteLine("Plus petit vaut {0:#.##} et le plus grand {1:#.##}", min, max);
        }

        static void Double(in int val, out int doubled)
        {
            doubled = val * 2;
        }

        static int Add(params int[] args  )
        {
            int sum = 0;
            foreach (int n in args)
            {
                sum += n;
            }
            return sum;
        }
    }
}

