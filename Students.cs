using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Students
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departments { get; set; }
        public Account stuAccount { get; set; }
        public Email EmailAddress { get; set; }

        private static int IDgenerator = 200000;
    }
}
