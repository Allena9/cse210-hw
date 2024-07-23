using System;
using System.Diagnostics.Metrics;
using System.IO;
using Microsoft.VisualBasic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        int menuOption = 0;

        while(menuOption != 6)
        {
            Console.WriteLine();
            ShowSpinner(1);

            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            menuOption = Int32.Parse(Console.ReadLine());

            if(menuOption == 1)
            {
                CreateGoal();
            }
            else if(menuOption == 2)
            {
                ListGoalDetails();
            }
            else if(menuOption == 3)
            {
                SaveGoals();
            }
            else if(menuOption == 4)
            {
                LoadGoals();
            }
            else if(menuOption == 5)
            {
                RecordEvent();
            }
            else if(menuOption != 6)
            {
                Console.Write("Invalid Input, please retry ");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public int ListGoalNames()
    {
        int counter = 0;

        Console.WriteLine("The goals are:");

        foreach(Goal goal in _goals)
        {
            counter++;
            Console.WriteLine($"{counter}. {goal.GetName()}");
        }

        return counter;
    }

    public void ListGoalDetails()
    {
        Console.Clear();

        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        int menuOption = 0;

        while(menuOption == 0)
        {
            Console.Clear();

            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3.Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            menuOption = Int32.Parse(Console.ReadLine());

            if(menuOption == 1)
            {
                Console.Write("what is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                SimpleGoal simple = new SimpleGoal(name, description, points);

                _goals.Add(simple);
            }
            else if(menuOption == 2)
            {
                Console.Write("what is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                EternalGoal eternal = new EternalGoal(name, description, points);

                _goals.Add(eternal);
            }
            else if(menuOption == 3)
            {
                Console.Write("what is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = Int32.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = Int32.Parse(Console.ReadLine());

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus, 0);

                _goals.Add(checklist);
            }
            else
            {
                menuOption = 0;
                Console.Write("Invalid Input, please retry ");
                ShowSpinner(3);
            }
        }

    }

    public void RecordEvent()
    {
        int counter = ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        int userSelection = Int32.Parse(Console.ReadLine());

        if(userSelection <= counter && userSelection > 0)
        {
            _score += Int32.Parse(_goals[userSelection - 1].RecordEvent());
        }
        else
        {
            Console.Write("Invalid Input, redirecting to menu. ");
            ShowSpinner(2);
        }
    }

    public void SaveGoals()
    {
        //Asks the name of the file. 
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        //Opens the requested file and inputs each entry in the journal
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
         //Clears current journal
        _goals.Clear();

        //Requests file name
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        
        //Opens requested file. Inputs Goal variables and saves entry to journal. Creates new Goal object every 3 lines. 
        string[] lines = System.IO.File.ReadAllLines(fileName);
        {
            foreach (string line in lines)
            {

                string[] classType = line.Split(":");

                //Checks which variable needs line. 
                if (classType[0] == "SimpleGoal")
                {
                    _goals.Add(CreateSimpleGoal(classType[1]));
                }
                else if (classType[0] == "EternalGoal")
                {
                    _goals.Add(CreateEternalGoal(classType[1]));
                }
                else if (classType[0] == "ChecklistGoal")
                {
                    _goals.Add(CreateChecklistGoal(classType[1]));
                }
                else
                {
                    _score = Int32.Parse(classType[0]);
                }
            }
        }
        
    }

    public SimpleGoal CreateSimpleGoal(string line)
    {
        string[] info = line.Split("_");

        string name = info[0];
        string description = info[1];
        string points = info[2];
        bool isComplete = bool.Parse(info[3]);

        SimpleGoal simple = new(name, description, points);
        if(isComplete == true)
        {
            simple.RecordEvent();
        }

        return simple;
    }

    public EternalGoal CreateEternalGoal(string line)
    {
        string[] info = line.Split("_");

        string name = info[0];
        string description = info[1];
        string points = info[2];

        EternalGoal eternal = new(name, description, points);

        return eternal;
    }

    public ChecklistGoal CreateChecklistGoal(string line)
    {
        string[] info = line.Split("_");

        string name = info[0];
        string description = info[1];
        string points = info[2];
        int bonus = Int32.Parse(info[3]);
        int target = Int32.Parse(info[4]);
        int amountCompleted = Int32.Parse(info[5]);

        ChecklistGoal eternal = new(name, description, points, target, bonus, amountCompleted);

        return eternal;
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
}