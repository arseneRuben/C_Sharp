using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    /// This class is used to describe each course
    /// </summary>
    class Course
    {
        public int Id { get; set; }
        public string Wording { get; set; }
        private List<Group> groups;
  
        public Teacher Professor;
        private int exercices;

        public List<Group> GetGroups()
        {
            return this.groups;
        }

        public void AddGroup(Group g)
        {
            this.groups.Add(g);
        }

        public void Remove(Group g)
        {
            if(this.groups.Contains(g))
                this.groups.Remove(g);
        }

        public int GetExercices()
        {
            return this.exercices;
        }

        public void SetExercices(int exo)
        {
            this.exercices = exo;
        }

        public Course(int id, String name,int exo)
        {
            this.Id = id;
            this.Wording = name;
            this.exercices = exo;
            this.groups = new List<Group>();
            

        }
        // Ajoute un constructeur qui prend aussi en parametre un prof
        public Course(int id, String name, int exo, Teacher prof)
        {
            this.Id = id;
            this.Wording = name;
            this.exercices = exo;
            this.Professor = prof;
           
            this.groups = new List<Group>();

        }

        public override string ToString()
        {
            return Id + " " + Wording +  " " + exercices + " exercices"+ Professor + " \n";
        }
    }
}
