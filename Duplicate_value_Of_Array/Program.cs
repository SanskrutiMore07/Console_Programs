using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_value_Of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 4, 1, 1 };
            Console.Write("Duplicate values Are :");

            for(int i = 0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        Console.Write(numbers[i]+" ");
                        Console.ReadLine();
                       
                    }
                }
            }
        }
    }
}
