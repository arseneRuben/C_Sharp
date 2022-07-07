using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Question11();
            Question12();
            Question13();
            Question21();
            Chat.Question3(); 
            Question33();*/
            Question32();
        }
        static void Question11()
        {
            double v1 = 54.130;
            sbyte v2 = -115;
            int v3 = 4825932;
            byte v4 = 97;
            short v5 = -10000;
            short v6 = 20000;
            byte v7 = 224;
            int v8 = 970700000;
            byte v9 = 112;
            sbyte v10 = -44;
            int v11 = -1000000;
            short v12 = 1990;
            ulong v13 = 123456789123456789;
        }

        static void Question12()
        {
            bool isMale = true;
        }

        static void Question13()
        {
            string hello = "Hello";
            string world = "World";
            object result = hello + world;
            Console.WriteLine(result.ToString());
        }

        static void Question21()
        {
            Console.Write("Give a mark(integer)");
            int mark = int.Parse(Console.ReadLine()), bonus = 0;
            switch (mark)
            {
                case 1:

                case 2:

                case 3:
                    bonus = mark * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    bonus = mark * 100;
                    break;
                case 7:
                case 8:
                    bonus = mark * 1000;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }

        static void Question31()
        {
            int nbElmt = 20;
            int[] tab = new int[nbElmt];
            for (int i = 0; i < nbElmt; i++)
            {
                tab[i] = i * 5;
                Console.Write(tab[i] + " ");
            }
        }

        static void Question32()
        {
            Console.Write(" La taille du premier tableau ");
            int t1 = int.Parse(Console.ReadLine());
            int[] tab1 = getTab(t1);
          //  print(tab1);
            Console.Write(" La taille du second tableau ");
            int t2 = int.Parse(Console.ReadLine());
            int[] tab2 = getTab(t2);
           // print(tab2);
            bool equality = (tab1.Length == tab2.Length);
            if (equality)
            {
                tab1=triBulle(tab1);
                print(tab1);
                tab2=triBulle(tab2);
                print(tab2);
            }
            int i = 0;
            while (equality && i < tab2.Length)
            {
                equality = (tab1[i] == tab2[i]);
                i++;
            }
            if (equality)
                Console.WriteLine("Egalite");
            else
                Console.WriteLine("Inegalite");
        }
        /// <summary>
        /// initializes as an array of nbElmt integers
        /// </summary>
        /// <param name="nbElmt"></param>
        /// <returns></returns>
        static int[] getTab(int nbElmt)
        {
            Console.WriteLine("Donnez les valeurs du tableau");
            int[] tab = new int[nbElmt];
            for (int i = 0; i < nbElmt; i++)
            {
                Console.Write(" {0} :  ", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
            }
            return tab;
        }
        static void print(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(" {0} ", tab[i]);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// asks for the size of an array, initializes it with integers, sorts it and displays the sorted array
        /// </summary>
        static void Question33()
        {
            Console.Write(" La taille du tableau ");
            int nbElmt = int.Parse(Console.ReadLine());
            
            int[] tab = getTab(nbElmt);
            // Collecte des valeurs du tableau
            // Trie
            triBulle(tab);
            // Affichage tableau trie
            print(tab);

        }
        /// <summary>
        /// sorts the bubble on the array of integers tab
        /// </summary>
        /// <param name="tab"></param>
        static int[] triBulle(int[] tab)
        {
            for (int i = 0; i < tab.Length ; i++)
            {
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                   
                    if (tab[j] > tab[j + 1])
                    {
                        permut(tab, j, j+1);
                    }
                }
            }
            return tab;
        }
        /// <summary>
        /// swaps the values of the array tab positioned at indices a and b
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void permut(int[] tab,int a, int b)
        {
            tab[a] = tab[a] + tab[b];
            tab[b] = tab[a] - tab[b];
            tab[a] = tab[a] - tab[b];
        }


    }
}