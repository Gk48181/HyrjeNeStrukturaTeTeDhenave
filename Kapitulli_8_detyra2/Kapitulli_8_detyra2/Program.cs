using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_8_detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1111010110011110 to decimal is {0}.",
          Convert.ToInt64("1111010110011110", 2));

            Console.WriteLine("1111010110011110 to hexadecimal is {0}.",
                Convert.ToInt64("1111010110011110", 2).ToString("X"));
        }
    }
}
