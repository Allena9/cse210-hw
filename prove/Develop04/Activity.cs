using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity()
    {

    }
    public void setDescription(string description)
    {
        _description = description;
    }
    public void setName(string name)
    {
        _name = name;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();

        Console.WriteLine($"{_description}");
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for(int i = 0; i <= seconds; i++)
        {
            Console.Write("|");

            Thread.Sleep(250);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character

            Thread.Sleep(250);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(250);

            Console.Write("\b \b"); // Erase the + character
            Console.Write(@"\"); // Replace it with the - character

            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - i);

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}