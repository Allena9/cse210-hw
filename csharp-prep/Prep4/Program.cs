using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int add = 1;
        int count = 0;
        float avg = 0;
        int largest = 0;
        int smallest = 100000000;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(add != 0)
        {
            Console.WriteLine("Enter number: ");
            add = int.Parse(Console.ReadLine());
            numbers.Add(add);
        }

        foreach(int number in numbers)
        {
            count = count + number;
            if(number > largest)
            {
                largest = number;
            }

            if(number > 0 && number < smallest)
            {
                smallest = number;
            }
        }


        avg = ((float)count) / numbers.Count;

        Console.WriteLine($"The sum is: {count}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        
    }
}