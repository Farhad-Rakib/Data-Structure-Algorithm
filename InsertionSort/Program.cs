using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = {40,10,50,30,20 };
            Console.WriteLine("Before Insertion Sort Array is  :");
            Display(array);
            Console.WriteLine("After Insertion Sort Array is  :");
            InsetionSortAlgorithm(array, array.Length);
        }
        private static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
        static int[] InsetionSortAlgorithm(int[] array,int size) 
        {
            for (int i = 1; i < size; i++) 
            { 
                int value = array[i];
                int index = i;

                while (index > 0 && array[index-1] > value)
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = value;
            }        
            Display(array);
            return array;
        }
    }
}
