using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 0, dCnt = 0,Temp = 0;

            Console.WriteLine("Enter A Number :");
            No = Convert.ToInt32(Console.ReadLine());

            Temp = No;

            while(Temp > 0)
            {
                Temp = Temp / 10;
                dCnt++;
            }
            Console.WriteLine("Count Of Digt In Given Number " + No + "  Is  " + dCnt);
            Console.ReadLine();
        }
    }
}
