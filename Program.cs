using System;

namespace numberGuesser
{
    class Program
    {
        static void GameGreeting()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to the Number Guesser Game");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            PromptForString("What is your name?");
            Console.WriteLine(($"Hello! Think of a number between 1 and 1024. Don't tell me your number!! I'll try to guess it correctly in 10 tries or less"));

        }

        static string PromptForString(string prompt)
        {
            Console.WriteLine(prompt);
            var userInput = Console.ReadLine();
            return userInput;

        }

        static void Main(string[] args)
        {
            //Start with some sort of method to display a greeting for Guessing game
            GameGreeting();

        }
    }
}
