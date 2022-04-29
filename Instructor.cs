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
        private string Password { get; set; }
        private static int IDgenerator = 10000;

        // Constructor
        public Instructor(string FirstName, string LastName, 
            string Department, string Password)
         {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Departments = Department;
            this.Password = Password;
            this.ID = IDgenerator;
            this.EmailAddress = new Email(FirstName, LastName, ID) ;
            IDgenerator++;
        }

        // Methods related to Courses
        public void CreateCourse()
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
