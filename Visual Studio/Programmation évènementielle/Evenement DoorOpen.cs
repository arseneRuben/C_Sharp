using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_évènementielle
{
    class DoorObserver
    {
        //4. In the observer, create a member variable of the observable type.
        internal protected Door Door { get; set; }
        // Constructeur sans parametre
        public DoorObserver()
        { }
        // Constructeur avec parametres
        public DoorObserver(Door door)
        {
            this.Door = door;
        }

        public void DoorOpened(object sender, DoorOpenEventArgs e)
        {
            Door door = (Door)sender;
            Console.WriteLine("Door {0}  opened  at {1} ", door.Id, e.Time);
        }
    }
    class SafetyGuard : DoorObserver
    {
        //5. In the observer, create a method (the event handler) according to the event delegate type defined in step 1.
        // Ici c'est juste une autre methode specifique 
        // cas par exp ou on veut changer de porte. on y arrive
        public void SwitchDoor(Door newDoor)
        {
            this.Door.DoorOpenEvent -= this.DoorOpened;
            newDoor.DoorOpenEvent += this.DoorOpened;
            this.Door = newDoor;
        }

    }
    class Owner: DoorObserver
    {
     
    }
}
