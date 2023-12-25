using System;

namespace Hashing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sizeOfHash = 0;
            Console.WriteLine("--------Hashing-------------------");
            Console.WriteLine("Enter the Size of the Hash : ");
            sizeOfHash = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("A Hash of " + sizeOfHash + " will be created ");

            HashingImplementationWithArray.init(sizeOfHash);

            for (int i = 0; i < sizeOfHash; i++)
            {
                
                HashingImplementationWithArray.insert(Convert.ToInt32(Console.ReadLine()));
            }
            

            HashingImplementationWithArray.DisplayHash();
        }
    }
}
