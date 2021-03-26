using System;

namespace MathLib
{
    public class Calculator
    {
        /*
         
         Add to the Calculator class from the previous
         exercise a method that takes two number inputs 
         from the console and then displays the maximum 
         of the two. Call the method from the main method.

        (hint: use the Console.ReadLine() method).
        
        */
        public void Max()
        {
            Console.WriteLine("Type the first number:");
            Int32.TryParse(Console.ReadLine(), out int x);

            Console.WriteLine("Type the second number:");
            Int32.TryParse(Console.ReadLine(), out int y);

            Console.WriteLine($"The largest number is {Math.Max(x, y)}");
        }
    }
}