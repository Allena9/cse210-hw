using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";

        //Asks user for grade and stores it as an integer.
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        //Sort what letter grade the user got. 
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }

        //Display letter grade.
        Console.WriteLine($"Your grade is: {letterGrade}");

        //Determine if user passed.
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. You'll do better next time!");
        }
    }
}