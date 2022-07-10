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
            test();
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

        static void test()
        {
            Console.WriteLine( 20 == GetMax(-2,3,20) ? "JUSTE" : "FAUX");
            Console.WriteLine(0 == GetMax(-2, -3, 0) ? "JUSTE" : "FAUX");
            Console.WriteLine(2 == GetMax(-2, 2, -20) ? "JUSTE" : "FAUX");
        }
    }
}
