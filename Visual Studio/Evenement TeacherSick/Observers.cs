using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenement_TeacherSick
{
    public enum ObserverType { STUDENT, ACCOUNTANT, DIRECTOR};
    class SicknessObserver
    {
        // Pour differencier mes observateurs, je vais creer un enumeration
        internal protected ObserverType Type;
        internal protected TeacherSick Sickness { get; set; }
        protected SicknessObserver(TeacherSick sickness)
        {
            this.Sickness = sickness;
           
        }
        
        public virtual void SicknessOccurs(object sender, TeacherSick e)
        {
           // TeacherSick teacher = (TeacherSick)e;
            Console.WriteLine("Teacher {0}  has been sick since   {1} day(s) ", e.Teacher, e.Days);
        }
    }

    class Student: SicknessObserver
    {
        public Student(TeacherSick sickness) : base(sickness)
        {
            this.Type = ObserverType.STUDENT;
        }
    }
    class Director : SicknessObserver
    {
        public Director(TeacherSick sickness) : base(sickness)
        {
            this.Type = ObserverType.DIRECTOR;
        }
    }
  
    class Accountant : SicknessObserver
    {
        public Accountant(TeacherSick sickness) : base(sickness)
        {
            this.Type = ObserverType.ACCOUNTANT;
        }
    }
}
