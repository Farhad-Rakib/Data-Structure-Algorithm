using System;
using System.ComponentModel;

namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 145,180,165,170,150 };
            Console.WriteLine("Before Selection Sort Array is  :");
            Display(array);
            Console.WriteLine("After Selection Sort Array is  :");
            SelectionSortAlgorithm(array, array.Length);

        }
        // position is fixed not the item.
        // Time Complexity:  O(n2)
        // space Complexity: O(n)

        public static int[] SelectionSortAlgorithm(int[] array, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if (array[i] > array[j]) 
                    {
                        swap(ref array[i], ref array[j]);
                    }

                }
            }
            Display(array);
            return array;
        }

        public static void swap(ref int x, ref int y) 
        { 
            int temp = x;
            x = y;
            y = temp;
        }

        private static void Display(int[] array) 
        { 
            for(int i = 0;i < array.Length;i++) 
            {
                Console.Write(" "+ array[i]);
            }
            Console.WriteLine();
        }

    }

    
}
