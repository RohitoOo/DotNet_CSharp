using System;

// Namespace 
namespace CSharp
{

// Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set App variables 
            string name  = "Rohito Bhambhani";

            // Change Text Color

            Console.ForegroundColor = ConsoleColor.Green;

            // Write out App Variales 
            Console.WriteLine("Hello World! Welcome, Mr. " + name );

            Console.ResetColor();
        }
    }
}
