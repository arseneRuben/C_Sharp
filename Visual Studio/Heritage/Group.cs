using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    ///  Cette classe decrit le groupe d'etudiants
    /// </summary>
    class Group
    {
        public string Identifiant { get; set; }
        private List<Student> students;
        private List<Course> courses;
        public List<Student> getStudents()
        {
            return this.students;
        }

        public void AddStudent(Student std)
        {
            this.students.Add(std);
        }

        public void RemoveStudent(Student std)
        {
            if (this.students.Contains(std))
            {
                this.students.Remove(std);
            }
        }

        public List<Course> getCourses()
        {
            return this.courses;
        }

        public void AddCourse(Course crs)
        {
            this.courses.Add(crs);
        }

        public void RemoveCourse(Course crs)
        {
            if (this.courses.Contains(crs))
            {
                this.courses.Remove(crs);
            }
        }

        //constructeurs
        public Group(string id)
        {
            this.Identifiant = id;
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        public Group(string id, List<Student> list )
        {
            this.Identifiant = id;
            this.students = list;
            this.courses = new List<Course>();
        }
        public Group(string id, List<Student> listStd, List<Course> listCrs)
        {
            this.Identifiant = id;
            this.students = listStd;
            this.courses = listCrs;
        }

        // Je veux presenter un groupe d'etudiant, les cours qu'ils suivent et les prof qui les enseignent
        public void print()
        {

            String output = this.Identifiant+"\n";
            output += (this.students.Capacity == 0) ? "" : "Liste des " + this.students.Capacity + " Etudiants\n";
            if(this.students.Capacity != 0)
            {
                foreach(Student std in this.students)
                {
                    output = output + std.ToString();
                }
            }

            output += (this.courses.Capacity == 0) ? "" : "Liste des " + this.courses.Capacity + " cours suivis\n";
            if (this.courses.Capacity != 0)
            {
                foreach (Course crs in this.courses)
                {
                    output = output + crs.ToString();
                }
            }
            Console.WriteLine(output);
        }
    }
}
