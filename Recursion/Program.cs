using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            int[] array = { 2,4,6 };
            Console.WriteLine (sumOfArrayusingRecursion(array));
        }

        static int sumOfArrayusingRecursion(int[] array)
        {
            if (array == null && array.Length == 0) 
            { 
                return 0; 
            }
            
            if (array.Length > 0) 
            { 
                
                List<int> list = new List<int>(array);
                list.RemoveAt(0);
                sumOfArrayusingRecursion(list.ToArray());
                sum += array[0];

            }

            return sum;
        }
    }
}
