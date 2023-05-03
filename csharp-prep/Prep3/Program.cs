using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        string play = "yes";

        while(play == "yes")
        {
            int magic = randomGenerator.Next(1,100);
            int guess = 0;
            int amount = 0;

            while(guess != magic)
            {

                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());

                amount++;

                if(guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if(guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == magic)
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"Times guessed = {amount}.");
            Console.WriteLine("Do you want to play again?");
            play = Console.ReadLine();
    }   }
    
}