using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fractions = new();
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        Fractions fractions1 = new(5);
        Console.WriteLine(fractions1.GetFractionString());
        Console.WriteLine(fractions1.GetDecimalValue());

        Fractions fractions2 = new(3, 4);
        Console.WriteLine(fractions2.GetFractionString());
        Console.WriteLine(fractions2.GetDecimalValue());

    }
}