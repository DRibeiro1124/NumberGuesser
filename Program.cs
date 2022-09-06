using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 1024;
            int middle = 0;
            string response = "";
            int numberOfGuesses = 0;
            string replay = "yes";

            while (PlayAgain(replay))
            {
                GameGreeting();
                while (response != "correct")
                {
                    middle = (min + max) / 2;
                    response = PromptCorrectGuess(middle);
                    numberOfGuesses++;

                    if (!ValidateResponse(response))
                    {
                        Console.WriteLine("Error! 📛 Please input a correct response. Exiting game in 3... 2... 1... 💣 💣 💣");
                        return;
                    };

                    if (response == "lower")
                    {
                        max = middle;
                    }

                    else if (response == "higher")
                    {
                        min = middle;
                    }
                }
                BragWhenCorrect(numberOfGuesses);
                Console.WriteLine($"Would you like to play again? " + "yes or no?");
                replay = Console.ReadLine().ToLower();
                min = 1;
                max = 1024;
                middle = 0;
                response = " ";
                numberOfGuesses = 0;
            }

        }


        static void GameGreeting()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to the Number Guesser Game");
            Console.WriteLine("☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ☀️ ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            var name = PromptForString("What is your name?");
            Console.WriteLine(($"Hello {name}! Think of a number between 1 and 1024. DO NOT TELL ME YOUR NUMBER!! I'll try to guess it correctly in 10 tries or less"));
        }

        static string PromptForString(string prompt)
        {
            Console.WriteLine(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }


        static string PromptCorrectGuess(int middle)
        {
            Console.WriteLine($"I think your number is {middle}! Am I CORRECT? or is it HIGHER or LOWER");
            return Console.ReadLine().ToLower();
        }

        static bool ValidateResponse(string response)
        {
            if (response == "correct" || response == "higher" || response == "lower")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool PlayAgain(string restartGame)
        {
            if (restartGame == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void BragWhenCorrect(int numberOfGuesses)
        {
            Console.WriteLine("As always, I win!!! 😎 😎 😎");
            Console.WriteLine($"I'm the greatest! 😉 It only took me {numberOfGuesses} guesses to pick your number correctly");
        }

    }

}