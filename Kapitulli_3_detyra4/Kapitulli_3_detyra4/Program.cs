using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_3_detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 452;
            Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);
        }
    }
}
