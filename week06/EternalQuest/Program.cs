//Here is the Eternal Quest program/game
//I went above and beyond by doing switch statements
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goal = new();
        Console.Clear();
        Console.WriteLine("Welcome to your goal tracking program.");
        goal.Start();
    }
}