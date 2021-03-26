﻿using System;
using MathLib;

namespace Ex5
{
    class Program
    {
        /*
         Create a Calculator class and put it in it's own MathLib 
         namespace. Optionally, create a separate folder for this class.

        Create an Add method in the calculator that takes two numbers 
        and returns their sum. Use it in the Main method of Program.cs.

        Add an overload method for Add that takes an array of integers, 
        adds them together, then returns the result. Use the for-each loop.

        Use this overload method in the Main method of the program.

        Print out the results.
         */
        static void Main(string[] args)
        {
            var c = new Calculator();
            Console.WriteLine(c.Add(2, 2));
            Console.WriteLine(c.Add(new int[] { 1, 2, 3 }));
        }
    }
}
