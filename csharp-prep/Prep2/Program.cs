using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;

        Console.WriteLine("What is your grade percentage?");
        string gradeString = Console.ReadLine();
        int percentage = int.Parse(gradeString);

        if(percentage >= 90)
        {
            letter = "A";
        }
        else if(percentage >= 80)
        {
            letter = "B";
        }
        else if(percentage >= 70)
        {
            letter = "C";
        }
        else if(percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You received a {letter}.");

        if(percentage >= 70)
        {
            Console.WriteLine("Congragulations, you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time.");
        }
    }
}