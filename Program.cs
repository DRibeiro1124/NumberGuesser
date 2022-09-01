using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGreeting();

            int min = 1;
            int max = 1024;
            int guess = 0;
            string response = "";
            int numberOfGuesses = 0;

            while (response != "correct")
            {
                guess = (min + max) / 2;
                response = PromptCorrectGuess(guess);
                numberOfGuesses++;

                if (!ValidateResponse(response))
                {
                    Console.WriteLine("Error! 📛 Please input the correct response. Exiting game");
                    return;
                };

                if (response == "lower")
                {
                    max = guess;
                }

                else if (response == "higher")
                {
                    min = guess;
                }

            }

            BragWhenCorrect();
            Console.WriteLine($"I'm the greatest! 😉 It only took me {numberOfGuesses} guesses to pick your number correctly");

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


        static string PromptCorrectGuess(int guess)
        {
            Console.WriteLine($"I think your number is {guess}! Am I CORRECT? or is it HIGHER or LOWER");
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

        static void BragWhenCorrect()
        {
            Console.WriteLine("As always, I win!!! 😎 😎 😎");
        }

    }

}