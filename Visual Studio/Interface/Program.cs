using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramHelper ph = new ProgramHelper();
            String code = "public class MyClass";
            code = (ph as IConvertible).ConvertToCSharp(code);
            Console.WriteLine(code);
            code = (ph as IConvertible).ConvertToVB(code);
            Console.WriteLine(code);
            Console.WriteLine((ph as ICodeChecker).CodeCheckSyntax(code,"#"));
        }
    }
}
