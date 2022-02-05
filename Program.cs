using System;

// Namespace
namespace numberGuesser
{
    // Main class
    internal class Program
    {
        // Entry point
        static void Main(string[] args)
        {
            GetAppInfo(); // run getappinfo to get info

            GreetUser(); // ask user name and greet

            while (true)
            {
                // Init Correct number
                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Init Correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct Loop
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print errpr ,essage
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");
                        // Keep going
                        continue;
                    }

                    // cast to int and put in guess var
                    guess = int.Parse(input);

                    // Match guess to the correct number
                    if (guess != correctNumber)
                    {
                        // Print Error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again buddy!");
                    }
                }

                // Print Error Message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!");

                //Play again?
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }
        // Display and get app info
        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Salaam Williams";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();
        }

        // Greet and display name
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string nameInput = Console.ReadLine();

            Console.WriteLine("Whats good {0}, let's play a game...", nameInput);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color
            Console.ForegroundColor = color;
            //Not a number message
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();
        }
    }
}
