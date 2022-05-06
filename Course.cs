using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Course
    {
        public string courseCode { get; set; }
        public Instructor courseIns { get; set; }
        public Assignments assignments { get; set; }
        
        public Course(string courseCode, Instructor courseIns, Assignments assignments)
        {
            this.courseCode = courseCode;
            this.courseIns = courseIns;
            this.assignments = assignments;
        }


    }
}
