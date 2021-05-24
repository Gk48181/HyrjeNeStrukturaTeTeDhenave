using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_9_detyra1
{
    class Program
    {

        static void ReturnName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());
        }
    }
}
