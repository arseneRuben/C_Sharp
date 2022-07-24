using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    //3
    public class StudentAgeException : Exception
    {
        public StudentAgeException() { }

        public StudentAgeException(string message)
            : base(message) { }

        public StudentAgeException(string message, Exception inner)
            : base(message, inner) { }
    }

    class Student
    {
        private int id;
        private string prenom;
        private int age;
        private int sexe;

        public int Id { get { return this.id; } set { this.id = value; } }
        public String Prenom { get { return this.prenom; } set { this.prenom = value; } }
        public int Age {
            get { return this.age; }
            set {
                if (value < 16 || value > 100) throw new StudentAgeException("Cet eleve a un age douteux");
                this.age = value;
            }
        }
        public int Sexe { get { return this.sexe; } set { this.sexe= value; } }
        public override String ToString()
        {
            string output= "Eleve num : "+ this.Id +" "+ this.Prenom + " " + this.Age ;
            if (this.sexe == 0)
                output += " Masculin";
            if (this.sexe == 0)
                output += " Feminin";
            return output;

        }

        public static void question3()
        {
            try
            {
                Student bryan = new Student();
                bryan.Prenom = "Bryan";
                bryan.Sexe = 0;
                bryan.Age = 17;
                bryan.Id = 1;
                Console.WriteLine(bryan);
                Student tresor = new Student();
                tresor.Prenom = "Tresor";
                tresor.Sexe = 1;
                tresor.Age = 13;
                tresor.Id = 1;
                Console.WriteLine(tresor);

            }
            catch (StudentAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    //2
    class AppUtils
    {
        private static List<int> StringToListInt(String input)
        {
            List<int> output = new List<int>();
            if (input == null) throw new ArgumentNullException("Chaine nulle imposible de parser");
            else
            {
                string[] tokens = input.Split(',');
                foreach(string tok in tokens)
                {
                    try
                    {
                        output.Add(int.Parse(tok.Trim()));
                    }catch(ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException caught");
                        //Console.WriteLine("Tous les segement ne sont pas des valeurs entieres");
                        //Console.WriteLine(e.StackTrace);
                        throw  new ArgumentException("Tous les segement ne sont pas des valeurs entieres");

                    }
                }
                return output;
            }
        }

        public static void question2()
        {
            try
            {
                Console.WriteLine("CAS NORMAL");
                
                //Console.Write(input + " contient les valeurs entieres suivantes:");
                 foreach(int entier in AppUtils.StringToListInt("12, 3, 45, 56"))
                {
                    Console.Write("{0} ",entier);
                }
                Console.WriteLine();
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException caught");
                Console.WriteLine("Valeur null en entree");
                Console.WriteLine(e.StackTrace);
            }



            try
            {
                Console.WriteLine("CAS D\'UNE ENTREE AVEC MAUVAISE VALEURS");
                AppUtils.StringToListInt("abc, 23, 34");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("CAS D\'UNE ENTREE NULLE");
                try
                {
                    AppUtils.StringToListInt(null);
                }catch(ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        
        }

       
    }
    class Program
    {
        public static void question1()
        {
            //1.1
            try
            {
                int i = 0;
                int res1 = 45 / i;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException caught");
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            

            //1.2

            try
            {
                int[] arrInt = new int[20];
                arrInt[20] = 15;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException caught");
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            

            //1.3

            try
            {
                int[] arrInt = null;
                arrInt[20] = 15;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException caught");
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            //4
            try
            {
                DateTime dt = DateTime.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException caught");
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }
        static void Main(string[] args)
        {
            // question1();

            // AppUtils.question2();
            Student.question3();

        }

    }

}
