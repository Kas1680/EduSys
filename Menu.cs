using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Menu
    {
        string error = "Error: Invalid Input";

        public void instructorMenu(Instructor inst)
        {
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("Please make a choice:");
                Console.WriteLine("1 - List courses");
                Console.WriteLine("2 - Create course");
                Console.WriteLine("3 - View Course");
                Console.WriteLine("4 - Log out");

                input = Console.Read();

                switch (input)
                {
                    case 1:
                        inst.ListCourses();
                        break;
                    case 2:
                        this.CreateCourseMenu();
                        break;
                    case 3:
                        inst.ViewCourses();
                        break;
                    case 4:
                        break;
                }
            }
         }

        public void studentMenu()
        {
             
        }

        public void TAMenu()
        {

        }
        
        public void generalMenu()
        {
            int userChoice = 0;
            while(userChoice != 3)
            {
                // First print the menu
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Sign up");
                Console.WriteLine("3 - Shutdown System");
                Console.Write("Enter Choice: ");
                userChoice = Console.Read();

                if(userChoice == 1)
                {
                   this.login();
                }
                else if (userChoice == 2)
                {
                    this.signup();
                }
                else if(userChoice == 3)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine(error);
                }
            }
        }
// -----------------------------------------------------------------//
        public void login()
        {
            int count = 3;
            string userID;
            string userPW;
            while(count > 0)
            {
                Console.WriteLine("User Name: ");
                userID = Console.ReadLine();
                Console.WriteLine("Password: ");
                userPW = Console.ReadLine();
            }
        }

        public void signup()
        {
            int input = 0;

            while (input != 1 || input != 2 || input != 3)
            {
                Console.WriteLine("Please make a choice:");
                Console.WriteLine("1 - I am a student");
                Console.WriteLine("2 - I am an instructor");
                Console.WriteLine("3 - I am a Teaching Assistant");
                input = Console.Read();

                switch (input)
                {
                    case 1:
                        this.CreateStudentAccount();
                        break;
                    case 2:
                        this.CreateInstructorAccount();
                        break;
                    case 3:
                        this.CreateTAAccount();
                        break;
                    default:
                        Console.WriteLine(error);
                        break;
                }

            }
        } 
// -----------------------------------------------------------------//

        public void CreateCourseMenu()
        {
            Console.WriteLine("Please Enter Course Code: ");
            string courseCode = Console.ReadLine();
            Console.WriteLine("Please Enter Program Name: ");
            string progName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }


// -----------------------------------------------------------------//

        public void CreateInstructorAccount()
        {

        }

        public void CreateStudentAccount()
        {

        }

        public void CreateTAAccount()
        {
                
        }
    }
}
