using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _count = 0;
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        base.setName("Listing");
        base.setDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);

        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        base.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random ran = new Random();

        Console.WriteLine($" --- {_prompts[ran.Next(5)]} --- ");
    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = [];

        //Creates the times needed to run the exersice for the requested time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        //Requests responses from the user.
        do
        {
            Console.Write("> ");
            userInput.Add(Console.ReadLine());
            _count++;

            currentTime = DateTime.Now;
        }while(endTime >= currentTime);

        return userInput;
    }
}