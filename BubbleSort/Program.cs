using System;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 145, 180, 165, 170, 150 };
            Console.WriteLine("Before Bubble Sort Array is  :");
            Display(array);
            Console.WriteLine("After Bubble Sort Array is  :");
            BubbleSort(array, array.Length);
        }


        private static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }

        // Select the larger Item or bubble in each iteration 
        // Time Complexity:  O(n2) , best case: 0(n)
        // space Complexity: O(n)
        static int[] BubbleSort(int[] nums, int size)
        {
            int flag;
            for (int i = 0; i < size - 1; i++)
            {
                flag = 0;
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1]) 
                    {
                        swap(ref nums[j], ref nums[j + 1]);
                        flag = 1;
                    }
                        
                }
                if (flag == 0) break;
            }
            Display(nums);

            return nums;
        }

        private static void swap(ref int i, ref int j)
        {
            int temp = i;

            i = j;
            j = temp;
        }
    }
}
