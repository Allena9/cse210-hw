using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction(21, 7);

        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());
    }
}