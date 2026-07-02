using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Alice", 30);                           // Create a new Person object using the constructor

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");   // Output the properties of the person to the console
        }
    }
}