using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenement_TeacherSick
{
    public delegate void DGTearcherSik();

    class SchoolReceptionist
    {
        
        public void newSickNess(int day, TeacherSick teach)
        {
            this.TeacherSickEvent(this,  teach);
        }

        public event EventHandler<TeacherSick> TeacherSickEvent;

    }
}
