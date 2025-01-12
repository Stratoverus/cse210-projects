using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = GetName();

        int number = FavNumber();

        int square = SquareNumber(number);

        Response(name, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcoem to the Program!");
    }

    static string GetName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int FavNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void Response(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}