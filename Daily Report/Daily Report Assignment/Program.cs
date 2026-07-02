using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the titles
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report.");

            // Ask for the student's name and store it as a string
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // Ask for the current course and store it as a string
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            // Ask for the page number and convert the input to an integer
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask for help status and convert the input to a boolean (true/false)
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask for positive experiences and store the specific details as a string
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Ask for general feedback and store the details as a string
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string generalFeedback = Console.ReadLine();

            // Ask for study duration and convert the input to a double to allow for partial hours
            Console.WriteLine("How many hours did you study today?");
            double studyHours = Convert.ToDouble(Console.ReadLine());

            // Print the closing message to signal the end of the report
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Keep the console window open until a key is pressed (useful for debugging)
            Console.ReadLine();
        }
    }
}

