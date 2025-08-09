using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversOf_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int No, Dig, Rev =0, Temp = 0;

            Console.WriteLine("Enter a Number :");
            No = Convert.ToInt32(Console.ReadLine());

            Temp = No;

            while(Temp>0)
            {
                Dig = Temp % 10;
                Rev = (Rev * 10) + Dig;
                Temp = Temp / 10;
            }
            Console.WriteLine("Revers Of Number Is :" + Rev);
            Console.ReadLine();
        }
    }
}
