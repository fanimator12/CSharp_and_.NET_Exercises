using System;

namespace Ex7
{
    class Program
    {
        /*
         
         Given two strings, a and b, return the result of putting them 
         together in the order abba, e.g. "Hi" and "Bye" returns "HiByeByeHi".

            Examples:

            MakeAbba("Hi", "Bye") → "HiByeByeHi"
            MakeAbba("Yo", "Alice") → "YoAliceAliceYo"
            MakeAbba("What", "Up") → "WhatUpUpWhat"
             
            You can use the usual string concatenation from Java, 
            but consider a C# specific approach.

            Call your method from the Main method a couple of 
            times with various input and verify the output.
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(MakeAbba("Hi", "Bye"));
            Console.WriteLine(MakeAbba("Yo", "Alice"));
            Console.WriteLine(MakeAbba("What", "Up"));
            Console.WriteLine(MakeAbba("A", "B"));
        }

        private static string MakeAbba(string a, string b)
        {
            return $"{a}{b}{b}{a}";
        }
    }
}
