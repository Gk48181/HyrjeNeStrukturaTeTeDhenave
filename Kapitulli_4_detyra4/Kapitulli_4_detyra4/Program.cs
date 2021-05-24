using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_4_detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNum = 2015;
            Console.WriteLine("|0x{0,-8:X|", hexNum);
            double fractNum = -1.856;
            Console.WriteLine("|0,-10:f2}|", fractNum);
        }
    }
}
