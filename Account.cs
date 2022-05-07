using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Account
    {
        public string UserName { get; set; }
        public Password Password { get; set; }

        public List<Account> ListOfAccounts { get; set; }
        public Account(string UserName, Password Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public bool verifyAccount(string userName, string password)
        {
            foreach(Account account in ListOfAccounts)
            {
                // UserName exists in the database, now check for password correctness
                if (account.getUser() == userName)
                {
                    if(account.getPw() == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return false;
        }

        public string getPw()
        {
            return this.Password.getPw();
        }
        
        public string getUser()
        {
            return this.UserName;
        }

        public bool isDuplicate(string userName)
        {
            foreach(Account account in ListOfAccounts){
                if(account.UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
