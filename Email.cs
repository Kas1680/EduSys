using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Email
    {
        public string Address { get; set; }

        public Email(string FirstName, string LastName, int ID)
        {
            this.Address = GenerateEmail(FirstName, LastName, ID);
        }

        private string GenerateEmail(string FirstName, string LastName, int ID)
        {
            string email;
            if (countDigit(ID) == 5)
            {
                email = Char.ToLower(FirstName[0]) + LastName.ToLower();
            }
            else
            {
                email = Char.ToLower(FirstName[0]) + LastName.ToLower() + ID;
            }
            return email;
        }

        private int countDigit(int n)
        {
            if (n < 0) return 0;
            if (n < 10) return 1;
            return 1 + countDigit(n / 10);
        }
    }
}
