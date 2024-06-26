using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        Journal journal = new Journal();

        //Displays menu and prompts user for selection
        while(counter != 5)
        {

            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            counter = Int32.Parse(Console.ReadLine());

            if (counter == 1)
            {
                journal.AddEntry();
                counter = 0;
            }
            else if (counter == 2)
            {
                journal.DisplayAll();
                counter = 0;
            }
            else if (counter == 3)
            {
                journal.LoadFromFile();
                counter = 0;
            }
            else if (counter == 4)
            {
                journal.SaveToFile();
                counter = 0;
            }

        }
    }
}