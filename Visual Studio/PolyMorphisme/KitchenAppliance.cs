using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisme
{
    class KitchenAppliance
    {
        public string Brand { get; set; }
        public DateTime ManufacturingDate { get; set; }

        public virtual void PowerOn() { Console.WriteLine("ALLUME"); }

    }
}
