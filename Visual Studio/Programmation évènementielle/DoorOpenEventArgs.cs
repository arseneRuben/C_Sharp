using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_évènementielle
{
    class DoorOpenEventArgs
    {
        public DateTime Time { get; set; }
        public DoorOpenEventArgs(DateTime time)
        {
            this.Time = time;
        }
        public DoorOpenEventArgs()
        {
            this.Time = DateTime.Now;
        }
    }
}
