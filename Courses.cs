using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Courses
    {
        public string courseCode { get; set; }
        public Instructor courseIns { get; set; }
        public Assignments assignments { get; set; }
    }
}
