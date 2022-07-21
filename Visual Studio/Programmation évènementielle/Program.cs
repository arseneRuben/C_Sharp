using Programmation_évènementielle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_evenementielle
{
    class Program
    {
        static void Main(string[] args)
        {
            // J'instancie une porte fermee
            Door aDoor = new Door() { Id = 1, IsOpen = false };
            // Je cree un gardien
            SafetyGuard robert = new SafetyGuard();
            // J'enregistre le gardien comme ecouteur de la porte
            aDoor.DoorOpenEvent += robert.DoorOpened;
            // Que se passe t-il si j'ouvre la porte?
            aDoor.IsOpen = true;

            Owner proprio = new Owner();
            aDoor.DoorOpenEvent += proprio.DoorOpened;
            aDoor.IsOpen = false;
            // A cet instant, il ya deux methodes dans l'event
            // Du coup, lorsquon ouvre la porte, les 2 methode sont appeles
            aDoor.IsOpen = true;
            


        }
    }
}
