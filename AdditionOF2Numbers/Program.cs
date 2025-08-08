using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOF2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;

            Console.WriteLine("Enter Value 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value 2:");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("Sum Of Given Number " + a + " And " + b + " is:" + sum);
            Console.ReadLine();

        }
    }
}
