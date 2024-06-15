using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        string first;
        string last;

        //Prompts for first and last name. Saves to corisponding variables. 
        Console.Write("What is you first name? ");
        first = Console.ReadLine();
        Console.Write("Whats your last name? ");
        last = Console.ReadLine();

        //Dispalys name in James Bond format. 
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}