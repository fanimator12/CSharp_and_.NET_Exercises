using System;

namespace Ex8
{
    class Program
    {
        /*
         
         Write a method with the following behaviour:

        Given an "outer" string of length 4, such as "<<>>", 
        and a word, return a new string where the word is 
        in the middle of the out string, e.g. "<<word>>".

        MakeOutWord("<<>>", "Yay") → "<<Yay>>"
        MakeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"
        MakeOutWord("[[]]", "word") → "[[word]]"
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(MakeOutWord("<<>>", "Yay"));
            Console.WriteLine(MakeOutWord("<<>>", "WooHoo"));
            Console.WriteLine(MakeOutWord("[[]]", "word"));
        }

        private static string MakeOutWord(string outer, string word)
        {
            return $"{outer.Substring(0, 2)}{word}{outer.Substring(2, 2)}";
        }
    }
}
