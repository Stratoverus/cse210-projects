using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter a list of numbers. When you enter 0, this will finish.");
        while (number != 0)
        {
            Console.Write("Please enter a number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            numbers.Add(number);

        }
        //Figure out the sum here
        int total = numbers.Sum();
        Console.WriteLine($"The total is {total}");
        
        //Figure out the average here
        double average = numbers.Average();
        Console.WriteLine($"The Average is {average}");

        //Figure out the largest number
        int largest = numbers.Max();
        Console.WriteLine($"The Largest number is {largest}");
    }
}