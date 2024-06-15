using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string playGame = "yes";

        while (playGame == "yes")
        {
            int guess;
            int counter = 0;
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 100);

            do
            {
                counter++;

                Console.Write("What is your guess? ");
                _ = int.TryParse(Console.ReadLine(), out guess);

                if (magicNum == guess)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (magicNum > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNum < guess)
                {
                    Console.WriteLine("Lower");
                }
            } while (magicNum != guess);

            Console.WriteLine($"Number of guesses: {counter}");
            
            Console.Write("Would you like to play again? (yes/no) ");
            playGame = Console.ReadLine();
        }
    }
}