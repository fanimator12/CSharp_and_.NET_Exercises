using System;

namespace Ex9
{
    class Program
    {
        /*
         
         Write a method with the following behaviour:

        Given a string and an int n, return a string 
        made of the first and last n chars from 
        the string. The string length will be at least n.

        NTwice("Hello", 2) → "Helo"
        NTwice("Chocolate", 3) → "Choate"
        NTwice("Chocolate", 1) → "Ce"
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(NTwice("Hello", 2));
            Console.WriteLine(NTwice("Chocolate", 3));
            Console.WriteLine(NTwice("Chocolate", 1));
        }

        private static string NTwice(string word, int n)
        {
            return $"{word.Substring(0, n)}{word.Substring(word.Length - n, n)}";
        }
    }
}
