﻿using System;
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
            Email myEmail = new Email("Kas", "Kai", 1680);
            Console.WriteLine(myEmail);
        }
    }
}