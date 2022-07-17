using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisme
{
    class Person
    {
       public String Name { get; set; }
       public void UseKitchenAppliance(KitchenAppliance ka)
        {

            ka.PowerOn();
        }

        public Person(String name)
        {
            this.Name = name;
        }

        
    }
}
