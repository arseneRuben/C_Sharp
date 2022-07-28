using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void DGSaySomething(String text);
    class Person
    {
        internal virtual void SaySomething(String text)
        {
            Console.WriteLine(text);
        }
    }
    class Chinese : Person
    {
        internal override void SaySomething(String txt)
        {
            Console.WriteLine("Chinese says " + txt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chinese ho = new Chinese();
            Person po = new Person();
            DGSaySomething yourDg = new DGSaySomething(po.SaySomething);
            yourDg("Hdsff iun");
            yourDg.Invoke("Hdsff iun");
            yourDg += ho.SaySomething;
            yourDg("Wonderful");
        }
    }
}
