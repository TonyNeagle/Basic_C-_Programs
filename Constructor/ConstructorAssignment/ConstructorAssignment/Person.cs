using System;

namespace ConstructorAssignment
{
    public class Person
    {
        public string Name { get; }             // Read-only property for the person's name 
        public int Age { get; }                 // Read-only property for the person's age

        public Person(string name, int age)     // Constructor that takes name and age as parameters
        {
            Name = name;                        // Assign the name parameter to the Name property
            Age = age;                          // Assign the age parameter to the Age property
        }
    }
}

