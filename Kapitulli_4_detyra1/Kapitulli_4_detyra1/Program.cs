using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_4_detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Consle.ReadLine());
            Console.Write("Second number: ");
            int b = Int32.Parse(Consle.ReadLine());
            Console.Write("Third number: ");
            int c = Int32.Parse(Consle.ReadLine());
            Console.WriteLine("Result is {0}", a + b + c);
        }
    }
}
