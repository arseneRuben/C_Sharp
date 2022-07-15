using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_partielles
{
    partial class Employe
    {
        public int Id
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public DateTime BirthDay
        {
            get; set;
        }
        public String SocialInsuranceNum
        {
            get; set;
        }
    }
}
