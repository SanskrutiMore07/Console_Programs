using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Of_Douplicate_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3,1,2,3,4 };
            int i =0, j = 0;
            Console.WriteLine("Count Of Double Value:");
            for(i=0;i<numbers.Length;i++)
            {
                int cnt = 0;
                for(j=0;j<numbers.Length;j++)
                {
                    if(numbers[i] == numbers[j])
                    cnt++;
                }
                if(cnt>1)
                {
                    Console.WriteLine(numbers[i] + " ocours " + cnt + " Times ");
                   
                }
            }
            Console.ReadLine();
        }
    }
}
