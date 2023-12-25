using System;

namespace Hashing
{
    public static class HashingImplementationWithArray
    {
        private static int[] array;
        public static void init(int n)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = -1;
            }

        }
        public static int insert(int value)
        {
            int sizeOfArray = array.Length;
            int key = value % sizeOfArray;
            int index = key;

            while (array[index] != -1) 
            { 
                index = (index + 1) % sizeOfArray;

                if (index == key) 
                {
                    Console.WriteLine("Hash is full. No more insertion.... ");
                    return 0;
                }
            }

            array[index] = value;

            return 1;

        }

        public static void DisplayHash()
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write("[  " + array[i] + " ]");
            }
        }
    }
}
