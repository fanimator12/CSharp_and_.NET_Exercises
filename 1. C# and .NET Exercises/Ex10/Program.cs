using System;
using System.Linq;

namespace Ex10
{
    class Program
    {
        /*
         
         Write a method with the following behaviour:

        Given an array length 1 or more of ints, 
        return the difference between the largest 
        and smallest values in the array.

        BigDiff([10, 3, 5, 6]) → 7
        BigDiff([7, 2, 10, 9]) → 8
        BigDiff([2, 10, 7, 2]) → 8
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(BigDiff(new int[] { 10, 3, 5, 6 }));
            Console.WriteLine(BigDiff(new int[] { 7, 2, 10, 9 }));
            Console.WriteLine(BigDiff(new int[] { 2, 10, 7, 2 }));
        }

        private static int BigDiff(int[] ints)
        {
            return ints.Max() - ints.Min();
        }
    }
}
