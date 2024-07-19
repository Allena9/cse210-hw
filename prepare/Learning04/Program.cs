using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("George Jungle", "English");
        MathAssignment math = new MathAssignment("Billy Bob", "Math", "7.3", "8-19");
        WritingAssignment writing = new WritingAssignment("Kyle Super", "English", "The Great Hunt");

        Console.WriteLine(assign.GetSummary());
        Console.WriteLine();

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}