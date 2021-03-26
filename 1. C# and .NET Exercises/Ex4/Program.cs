using System;

namespace Ex4
{
    class Program
    {
        /*
        a) Create a new project for this exercise, 
        inside the solution folder for today's session

        b) Write a method, which prints out all even numbers 
        between 0 and x, where x is a method parameter. 
        Call it from the Main method and verify the output.

        c) Write a method, which prints out all uneven 
        numbers between 0 and x, where x is a method parameter. 
        Call it from the Main method and verify the output.

        d) Write a method, which prints out all numbers divisible by y, 
        between 0 and x, where x and y are method parameters. 
        Call it from the Main method and verify the output.
         */
        static void Main(string[] args)
        {
            PrintEvenNumbers(20);
            PrintUnevenNumbers(20);
            PrintDivisibleNumbers(20, 4);
        }

        private static void PrintEvenNumbers(int x)
        {
            Console.WriteLine($"Printing even numbers up to {x}:");
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void PrintUnevenNumbers(int x)
        {
            Console.WriteLine($"Printing uneven numbers up to {x}:");
            var n = 0;
            while (n <= x)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }

        private static void PrintDivisibleNumbers(int x, int y)
        {
            Console.WriteLine($"Printing numbers divisible by {y} up to {x}:");

            var n = 0;
            while (n <= x)
            {
                if (n % y == 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }
}
