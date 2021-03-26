using System;
using System.Collections.Generic;

namespace Ex5
{
    class Program
    {
        /*
        Create a class Car with at least the properties Color, 
        EngineSize, FuelEconomy (in liters pr 100km) and 
        IsManualShift.

        Override ToString() so that it prints the properties 
        of the car. Create a List of five or more cars with 
        varying properties. You could create a method to auto 
        generate random cars.

        Create a predicate method that takes a Car as argument 
        and checks if the car is a particular color. Use the 
        predicate method in combination with the FindAll() 
        method of the List instance to find all cars of that 
        color in your list and then print them to the terminal.
   
        Replace your predicate method with lambda expressions 
        to find all cars that match the following:

        * a particular color

        * an engine size bigger than some value

        * a fuel economy lower than some value

        * a condition combining 2 or more properties

        You should create a lambda expression for each condition 
        above and test your lambda expressions one by one by 
        printing the results to the terminal.
         */
        static void Main(string[] args)
        {
            var cars = new List<Car> {
                new Car("blue", 2, 3, true),
                new Car("red", 3, 4, false),
                new Car("black", 56, 100, false),
                new Car("orange", 42, 1337, true),
                new Car("yellow", 22, 20, true)
            };

            foreach (Car c in cars.FindAll(IsCarOrange))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.Color.Equals("orange")))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.EngineSize > 42))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.FuelEconomy < 50))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.Color.Equals("black") && car.EngineSize > 50))
            {
                Console.WriteLine(c);
            }
        }

        static bool IsCarOrange(Car car)
        {
            return car.Color.Equals("orange");
        }
    }
}
