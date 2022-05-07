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
        public Account insAccount { get; set; }
        public Email EmailAddress { get; set; }
        private static int IDgenerator = 10000;

        // Constructor
        public Instructor(string FirstName, string LastName, 
            string Department, string pw)
         {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Departments = Department;
            this.ID = IDgenerator;
            this.insAccount = new Account(IDmaker(FirstName, LastName), new Password(pw));
            this.EmailAddress = new Email(FirstName, LastName, ID) ;
            IDgenerator++;
        }

        public string IDmaker(string FirstName, string LastName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FirstName[0]);
            sb.Append(LastName);
            sb.Append(this.ID);
            return sb.ToString();
        }

//------------------------------------------------------Getter Here
        public string getPw()
        {
            return this.insAccount.getPw();
        }

        public string getFirstName()
        {
            return this.FirstName;
        }

        public string getLastName()
        {
            return this.LastName;
        }

        public int getID()
        {
            return this.ID;
        }

        public string getDepartment()
        {
            return this.Departments;
        }

        public string getEmail()
        {
            return this.EmailAddress.getEmail();
        }

//------------------------------------------------------Other Functions
        public void CreateCourse(string courseName, int courseID)
        {
            
        }

        public void ViewCourses()
        {
        
        }
        
        public void ListCourses()
        {

        }

        


















    }
}
