using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Instructor kas = new Instructor("Kas", "Kai", "Math", "asdf123");
            Console.WriteLine(kas.getPw());
            Console.WriteLine(kas.getEmail());

            Menu menu = new Menu();
        }
    }
}
