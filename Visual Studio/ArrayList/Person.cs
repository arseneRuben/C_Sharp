using System;


namespace ArrayListCours
{
    public abstract class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Person(String n, int a)
        {
            this.Name = n;
            this.Age = a;
        }

        public override String ToString()
        {
            return this.Name + " ";
        }
    }

    public class Student : Person
    {
        private int stuNumber;
        public int StuNumber
        {
            get { return stuNumber; }
        }

        public Student(int num, int a, string n):base(n,a)
        {
            this.stuNumber = num;
        }

        public override String ToString()
        {
            return base.ToString() + this.StuNumber + " \n";
        }
    }

    public class Employe : Person
    {
        public int Salary { get; set; }
        public Employe(string n, int a , int s) : base(n, a)
        {
            this.Salary = s;
        }

        public override String ToString()
        {
            return base.ToString() + this.Salary + "$ \n";
        }
    }
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("GO");
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            Student std1 = new Student(1, 21, "Alfred");
            Student std2 = new Student(2, 23, "Dan");
            Employe emp1 = new Employe("Jerry", 43, 2300);
            Employe emp2= new Employe("Pascal", 33, 2200);
            list.Add(std1);
            list.Add(emp1);
            list.Add(std1);
            list.Add(std2);
            foreach (Person p in list)
            {
                if(p is Student)
                {
                    Console.WriteLine((Student)p);
                }
                if(p is Employe)
                {
                    Console.WriteLine((Employe)p);
                }
            }
        }
    }
}
