using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitulli_1_detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_nr = 2;
            int last_nr = 100;
            for(int i=first_nr; i<=last_nr; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("-" + i + ",");
                }
                else
                {
                    Console.Write(i +",");
                }
            }
        }
    }
}
