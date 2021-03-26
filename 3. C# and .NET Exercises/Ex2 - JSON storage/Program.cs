using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Ex2
{
    class Program
    {
        /*
         Reuse the Person class from the previous exercise.

        This exercise is about making persistent storage 
        with JSON and a file. You will be using this in 
        your first assignment in a few weeks.

        Create a method, StoreObjects(List<Person> people), 
        that will take a List of Person objects and write to a file.

        Test it with the test person objects you created in 
        the previous exercise.

        If you don't give an absolute path to your file, 
        you should be able to find it like so:

        First, change from solution view to File System.
        
        Then navigate to here the bin/Debug/netcoreapp3.1 folder - MyLines.txt
        
        Check the output of the file.

        Now create another method to read from the file again, 
        and make a string of it, which can be serialized back 
        into a List of Persons.    

        To inspect the deserialized result, you can create a 
        break point after that line of code, and inspect the list.
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
            
            StoreObjects(people);
            ReadObjects();
        }

        private static void StoreObjects(List<Person> people)
        {
            File.WriteAllText("people.json", JsonSerializer.Serialize(people));
        }

        private static void ReadObjects()
        {
            var people = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("people.json"));
        }
    }
}
