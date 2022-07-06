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
            Question21();*/
            Chat.Question3();
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


    }
}