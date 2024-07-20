using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        base.setName("Reflection");
        base.setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    }

    public void Run()
    {
        base.DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the follwoing questions as the related to this exerience.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);

        Console.Clear();

        //Creates the times needed to run the exersice for the requested time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        do
        {
            DisplayQuestion();
            Console.WriteLine();
            base.ShowSpinner(10);

            currentTime = DateTime.Now;
        }while(endTime > currentTime);

        base.DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        Random ran = new Random();

        return _prompts[ran.Next(4)];
    }
    public string GetRandomQuestion()
    {
        Random ran = new Random();

        return _questions[ran.Next(9)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestion()
    {
        Console.Write("> ");
        Console.Write(GetRandomQuestion());
        
    }
}