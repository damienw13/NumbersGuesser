using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGuesser
{
    class Program
    {


        //Entry Point Method
        static void Main(string[] args)
        {
            // Run Get app info func
            GetAppInfo();

            //Ask user name
            GreetUser();

            while(true) 
            { 

                // Create a new Random object
                Random random = new Random();
            int correctNumber = random.Next(1, 10);


            // Init Guess var
            int guess = 0;

            // Ask User For Number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess isnt correct
            while (guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(input, out guess))
                {
                        //Print error message
                        PrintColourMessage(ConsoleColor.Red, "Please use an actual number");

                    // Keep going
                    continue;
                }

                // Cast To int and put in guess
                guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print Error message
                        PrintColourMessage(ConsoleColor.Red, "Wrong number please try again!");
                    }
                    
            }
                // output success message

                // Print Error message
                PrintColourMessage(ConsoleColor.Yellow, "CORRECT!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                   
                {
                    continue;
                }
                else if (answer == "N")
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
            // Set app vars
            string appName = "Numbers Guesser";
            string appVersion = "1.0";
            string appAuthor = "Damien Watkin";

            // change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write our app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text colour
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask Users Name
            Console.WriteLine("What is your name?");

            // Get User Input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, Lets Play A Game", inputName);
        }
        //Print Colour Message
        static void PrintColourMessage(ConsoleColor color, string message)
        {
            // change text colour
            Console.ForegroundColor = color;

            // tell user its not a number
            Console.WriteLine(message);

            // reset text colour
            Console.ResetColor();
        }
    }
}
