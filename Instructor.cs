using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Instructor {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departments { get; set; }

        public Email EmailAddress { get; set; }
        private Password password { get; set; }
        private static int IDgenerator = 10000;

        // Constructor
        public Instructor(string FirstName, string LastName, 
            string Department, string pw)
         {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Departments = Department;
            this.password = new Password(pw);
            this.ID = IDgenerator;
            this.EmailAddress = new Email(FirstName, LastName, ID) ;
            IDgenerator++;
        }

        public string getPW()
        {
            return this.password.getPw();
        }
        // Methods related to Courses
        public void CreateCourse(string courseName, int courseID)
        {

        }

        public void ViewCourse()
        {

        }
        
        public void ListCourses()
        {

        }

        // Actions Related to Assignments
        


















    }
}
