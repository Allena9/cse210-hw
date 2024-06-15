using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int number;
        int square;

        DisplayWelcome();
        name = PromptsUserName();
        number = PromptsUserNumber();
        square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptsUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptsUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNum = int.Parse(Console.ReadLine());

        return userNum;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}