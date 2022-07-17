using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisme
{
    class Microwave:KitchenAppliance
    {
        public override void PowerOn()
        {
            Console.WriteLine("Microwave:");
            base.PowerOn();
        }
    }
}
