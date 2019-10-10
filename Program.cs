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

            // Reset Color 
            Console.ResetColor();

            // Ask User's name 
            Console.WriteLine("What is your name ? "); 
           
            // Get User's input
            string input =  Console.ReadLine();

            Console.WriteLine("Let's Play a game, {0} " , input);
        }
    }
}
