using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class ListOfAccounts
    {
        public List<List<Account>> accountList { get; set; }

        public List<Account> insAccount { get; set; }
        public List<Account> studentAccount { get; set; }
        public List<Account> TAAccount { get; set; }
        public ListOfAccounts()
        {
            this.accountList = new List<List<Account>>()
            // 3 Account List of Instructor, Student and TA
            {
                new List<Account>(),
                new List<Account>(),
                new List<Account>()
            };
        }

        public List<List<Account>> getAccount()
        {
            return this.accountList;
        }
    }




}
