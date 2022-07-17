using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisme
{
    class Stove:KitchenAppliance
    {
        public override void PowerOn()
        {
            Console.WriteLine("Stove:");
            base.PowerOn();
        }
    }
}
