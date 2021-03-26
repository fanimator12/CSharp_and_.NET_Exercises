using System;

namespace Ex11
{
    class Program
    {
        /*
         
        Write a method with the following behaviour:

        Say that a "clump" in an array is a series 
        of 2 or more adjacent elements of the same 
        value. 
        
        Return the number of clumps in the given array.

        CountClumps([1, 2, 2, 3, 4, 4]) → 2
        CountClumps([1, 1, 2, 1, 1]) → 2
        CountClumps([1, 1, 1, 1, 1]) → 1
        
        */
        static void Main(string[] args)
        {
            Console.WriteLine(CountClumps(new int[] { 1, 2, 2, 3, 4, 4 }));
            Console.WriteLine(CountClumps(new int[] { 1, 1, 2, 1, 1 }));
            Console.WriteLine(CountClumps(new int[] { 1, 1, 1, 1, 1 }));
        }

        private static int CountClumps(int[] ints)
        {
            int clumps = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                int clump = 0;

                while (i < ints.Length - 1 && ints[i] == ints[i + 1])
                {
                    clump = 1;
                    i++;
                }

                if (clump == 1)
                {
                    clumps++;
                }
            }
            return clumps;
        }
    }
}
