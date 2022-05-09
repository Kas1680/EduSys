using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EduSys
{
    internal class EduSys
    {
        public List<Instructor> ListOfInst;
        public List<Students> ListOfStud;
        public List<TA> ListOfTA;
        public List<Course> ListOfCourse;
        public List<Assignments> ListOfAssignment;

        public EduSys()
        {
            ListOfInst = new List<Instructor>();
            ListOfStud = new List<Students>();
            ListOfTA = new List<TA>();
            ListOfCourse = new List<Course>();
            ListOfAssignment = new List<Assignments>();
        }

        // Read A file of data
        private void ReadInfo()
        {
            string filename = "";
                    
        }


    }
}
