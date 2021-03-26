using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Ex1
{
    class Program
    {
        /*
         In a Main method, create 3 person objects with various data.

        Put them in a List<Person>.

        Use JsonSerializer.Serialize(list) to serialize your 
        list of Person to a string, and print out this string.

        You will see it's not very readable because of the lack 
        of formatting. This is fine, if you are just storing 
        the data in a file, or sending it to somewhere.
         */
        static void Main(string[] args)
        {
            var Jakob = new Person
            {
                FirstName = "Jakob",
                LastName = "Knop",
                Age = 32,
                Height = 178,
                IsMarried = false,
                Sex = 'm',
                Hobbies = new string[] { "programming, gaming" }
            };

            var Kasper = new Person
            {
                FirstName = "Kasper",
                LastName = "Knop",
                Age = 32,
                Height = 176,
                IsMarried = false,
                Sex = 'm',
                Hobbies = new string[] { "work, roasting students" }
            };

            var Troels = new Person
            {
                FirstName = "Troels",
                LastName = "Mortensen",
                Age = 12,
                Height = 133,
                IsMarried = false,
                Sex = 'f',
                Hobbies = new string[] { "dancing, cooking" }
            };

            var people = new List<Person> { Jakob, Kasper, Troels };
            
//But if you want to be able to inspect the result, you can call the method like this:
            var peopleJson = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine(peopleJson);
        }
    }
}
