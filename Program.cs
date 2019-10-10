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
            string name = "Rohito Bhambhani";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out App Variales 
            Console.WriteLine("Hello World! Welcome, Mr. " + name);

            // Reset Color 
            Console.ResetColor();

            // Ask User's name 
            Console.WriteLine("What is your name ? ");

            // Get User's input
            string inputName = Console.ReadLine();

            // Write out User's input 
            Console.WriteLine("Let's Play a game, {0} ", inputName);


            while (true) {
                // Set Correct Number To Be Guessed By User

                // int correctNumber = 12;

                // Create a new Random Object

                Random random = new Random();

                int correctNumber = random.Next(1, 15);


                // Initialize guess variable 
                int guess = 0;


                // Ask user for number 
                Console.WriteLine("Guess a number between 1 and 15");

                // While Loop Untill The User Guesses the Correct Number 
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();


                    // Check if input is in the correct format 

                    if (!int.TryParse(input, out guess))
                    {

                        // Change Text Color
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        // Write out App Variales 
                        Console.WriteLine(input + " !! Really! " + inputName + ". Enter an actual number. You dummy!!!");

                        // Reset Color 
                        Console.ResetColor();

                        // Keep Going
                        continue;
                    }

                    // Cast to int and make as value for guess variable 

                    guess = Int32.Parse(input);

                    // Match guess to correctNumber 

                    if (guess <= 0 || guess >= 16)
                    {

                        // Change Text Color
                        Console.ForegroundColor = ConsoleColor.Blue;

                        // Write out App Variales 
                        Console.WriteLine(guess + " is the not between 1 and 15 , " + inputName + ". You dummy!!!");

                        // Reset Color 
                        Console.ResetColor();
                    }

                    else if (guess != correctNumber)
                    {

                        // Change Text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Write out App Variales 
                        Console.WriteLine(guess + " is the wrong Number, " + inputName);

                        // Reset Color 
                        Console.ResetColor();

                    }
                    else
                    {
                        // Change Text Color
                        Console.ForegroundColor = ConsoleColor.Green;

                        // Write out App Variales 
                        Console.WriteLine(guess + " is the CORRECT Number, Well Done " + inputName);

                        // Reset Color 
                        Console.ResetColor();

                    }

                                


                }

            }


        }
    }
}
