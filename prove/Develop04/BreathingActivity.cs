using System;
using System.Diagnostics.Metrics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        base.setName("Breathing");
        base.setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {

        base.DisplayStartingMessage();
        //Figures out how long the breathing intervals should be.
        int counter;
        if(_duration % 5 == 0)
        {
            counter = 5;
        }
        else if(_duration % 3 == 0)
        {
            counter = 3;
        }
        else if(_duration % 2 == 0)
        {
            counter = 4;
        }
        else
        {
            counter = 5;
        }

        //Creates the times needed to run the exersice for the requested time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        //Runs breathing part of program.
        do
        {
            
            Console.WriteLine();

            Console.Write("Breathe in...");
            base.ShowCountDown(counter);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            base.ShowCountDown(counter);
            Console.WriteLine();
            
            currentTime = DateTime.Now;
        }while(endTime >= currentTime);

        base.DisplayEndingMessage();
    }
}