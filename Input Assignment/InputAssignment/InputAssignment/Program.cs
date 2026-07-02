using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Security;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number:");
            // Log the number to a text file
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Tony\OneDrive\Documents\Notes\Console Application Assignment.txt", true))
            {
                string input = Console.ReadLine();
                writer.WriteLine(input);
            }

            //print the number back to the user
            string filePath = @"C:\Users\Tony\OneDrive\Documents\Notes\Console Application Assignment.txt";
            // Read the last line written to the file and print it
            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath);
                string text = lines.Any() ? lines.Last() : string.Empty;
                Console.WriteLine("You entered: " + text);
            }
            else
            {
                Console.WriteLine("File not found: " + filePath);
            }

        }
    }
}


