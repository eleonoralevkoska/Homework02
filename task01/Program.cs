using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        public static int SumEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)

                    sum += array[i];
            }                       
            
            return sum;
        }
        static void Main(string[] args)
        {
            int[] array = new int[6];
            
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter integer no.{i}:");
                array[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"The result is:{SumEven(array)}");
            Console.ReadLine();
             
        }
    }
}

