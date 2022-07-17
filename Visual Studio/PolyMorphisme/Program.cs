using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Person samuel = new Person("Samuel");
            KitchenAppliance stove = new Stove(), mw = new Microwave();
            samuel.UseKitchenAppliance(stove);
            samuel.UseKitchenAppliance(mw);
        }
    }
}
