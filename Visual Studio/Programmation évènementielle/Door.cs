using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_évènementielle
{
    class Door
    {
        private bool isOpen;
        public int Id { get ; set; }
        public bool IsOpen {
            get { return this.isOpen; }

            set { 
                // Au moment d'ouvrir une porte, si elle etait ferme
                if (!this.isOpen && value)// dans notre cas, elle est suppose etre vrai au moment ou on ouvre la porte
                {
                    // Je passe au notification des ecouteurs
                    this.DoorOpenEvent(this, new DoorOpenEventArgs());
                }
                this.isOpen = value;
            }
       }

        // 2. In the observable, create a member variable (data member) of this delegate. This member variable will be the event.
        //public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler<DoorOpenEventArgs> DoorOpenEvent;

    }
}
