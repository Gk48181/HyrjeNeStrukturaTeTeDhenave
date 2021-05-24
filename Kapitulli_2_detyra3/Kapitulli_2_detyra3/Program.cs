using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_2_detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 2333.234322;
            double num2 = 2333.234321;
                bool equal=Math.Abs(num1-num2)< 0.000001;
            Console.WriteLine(equal);
            num1 += num2;
            Console.WriteLine(num1.ToString("#.######"));
        }
    }
}
