using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class ProgramHelper : ICodeChecker
    {// Je dois conduire une reunion en ligne 
         string IConvertible.ConvertToCSharp(string code)
        {
            Console.WriteLine("Conversion du code en c#");
            return "c#" + code;
        }

         string IConvertible.ConvertToVB(string code)
        {
            Console.WriteLine("Conversion du code en VB");
            return "vb" + code;
        }

        bool ICodeChecker.CodeCheckSyntax(string code1, string language)
        {
            return code1.Contains(language);
        }

        

       
    }
}
