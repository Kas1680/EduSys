using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    internal class EduSys
    {
        public List<Instructor> ListOfInst;
        public List<Students> ListOfStud;
        public List<TA> ListOfTA;

        public EduSys()
        {
            ListOfInst = new List<Instructor>();
            ListOfStud = new List<Students>();
            ListOfTA = new List<TA>();
        }

    }
}
