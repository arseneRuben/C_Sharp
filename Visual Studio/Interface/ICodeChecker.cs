using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICodeChecker:IConvertible
    {
        bool CodeCheckSyntax(string code1, string language);
    }
}
