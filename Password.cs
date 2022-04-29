using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    public class Password
    {
      public string password { get; set; } 
        
        public Password(string pw)
        {
            this.password = pw;
        }

        /* 
         * Password requirement is to have 1 uppercase, 1 lowercase, 1 symbol and 
         * one number. Length has to be at least 8 character long
        */ 
        private bool verifyPW(string pw)
        {
            bool isVer = false;                

            if(pw.Length >= 8)
            {
                int upperChar = 0;
                int lowerChar = 0;
                int Symbol = 0;
                int Numb = 0;

                for(int i = 0; i < pw.Length; i++)
                {
                    if (Char.IsUpper(pw[i]))
                    {
                        upperChar++;
                    }
                    else if (Char.IsLower(pw[i]))
                    {
                        lowerChar++;
                    }
                    else if(pw[i].GetType() == typeof(int)){
                        Numb++;
                    }
                }

                if(pw.Any(ch => !Char.IsLetterOrDigit(ch)))
                {
                    Symbol++;
                }

                if(Symbol > 0 && upperChar > 0 && lowerChar > 0 && Numb > 0)
                {
                    isVer = true;
                }

            }

            return isVer;
        }

    }
}
