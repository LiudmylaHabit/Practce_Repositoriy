﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_Repositariy
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListPr inst = new ArrayListPr();
            inst.ShowYourself();

            NewClass cla = new NewClass("Mary", 25);

            Console.WriteLine(cla.Name + " " + cla.Number);

        }
    }
}
