using System;

namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo to get info at first

            GreetingUser(); // Ask user's name and greet

            while (true)
            {
                // Init correct number
                //int correctNumber = 7;

                // Create a new random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please enter a real number");
                        
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");

                    }

                }

                PrintColorMessage(ConsoleColor.Green, "Yes, this number is true!");

                // Ask to play again
                Console.WriteLine("Do you wanna play again? [Y or N]");

                string answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                {
                    continue;
                }
                else if (answer.ToUpper() == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Cansu Aktaş";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Magenta;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

        }

        static void GreetingUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {

            // Change text color
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
