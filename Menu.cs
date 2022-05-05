using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Menu
    {
        public void instructorMenu()
        {

        }

        public void studentMenu()
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

                userChoice = Console.Read();

                if(userChoice == 1)
                {
                    login();
                }
                else if (userChoice == 2)
                {
                    signup();
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
        }

        public void login()
        {
            int count = 3;
            int userID; 
            while(count > 0)
            {
                Console.WriteLine("Please enter your user ID: ");
                userID = Console.Read();
                
            }
        }

        public void signup()
        {

        }
        
    }
}
