using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int favNum;
        int squareNumber;

        DisplayWelcome();
        name = PromptUserName();
        favNum = PromptUserNumber();
        squareNumber = SquareNumber(favNum);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        string input;
        Console.WriteLine("Please enter your name: ");
        input = Console.ReadLine();
        return input;
    }

    static int PromptUserNumber()
    {
        int input;
        Console.WriteLine("Please enter your favorite number: ");
        input = int.Parse(Console.ReadLine());
        return input;
    }

    static int SquareNumber(int number)
    {
        int output = number * number;
        return output;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }


}