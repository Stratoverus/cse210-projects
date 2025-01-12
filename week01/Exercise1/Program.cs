using System;

class Program
{
    static void Main(string[] args)
    {
        //Get first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        //Get last name
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        //Put together
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}