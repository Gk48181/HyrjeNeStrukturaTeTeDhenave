﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_8_detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1}.",
                hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
