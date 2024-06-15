using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int temp = -1;
        int sum = 0; 
        double average;
        int largestNum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(temp != 0)
        {
            Console.Write("Enter number: ");
            temp = int.Parse(Console.ReadLine());
            numbers.Add(temp);

        }
        
        //Count the sum, and find the largest number.
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        //Calculate the average.
        average = Convert.ToDouble(sum) / Convert.ToDouble(numbers.Count);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}