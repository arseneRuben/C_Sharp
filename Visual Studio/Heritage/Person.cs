using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    abstract class Person
    {
        /// <summary>
        /// This property is sufficient to describe the group to which the individual belongs (Student or Teacher)
        /// </summary>
        protected Group Groupe {get; set;}
        protected int Id {get; set;}
        protected string Name { get; set; }
        // C'est bien sur le constructeur sans lequel on ne peut creer des etudiant ou enseignants
        public Person(int id, string name, Group g)
        {
            this.Id = id;
            this.Name = name;
            this.Groupe = g;
        }

        public override string ToString()
        {
            return Id + " " + Name + " \n";
        }
    }
}
