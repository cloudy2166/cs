using System;

namespace Utilities
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}

namespace Models
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Utilities.Logger.Log("Starting the application.");

            var person = new Models.Person
            {
                Name = "John Doe",
                Age = 25
            };

            Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");

            Utilities.Logger.Log("Exiting the application.");
        }
    }
}
