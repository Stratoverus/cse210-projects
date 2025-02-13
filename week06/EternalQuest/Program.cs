//Here is the Eternal Quest program/game
//I went above and beyond by doing switch statements
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goal = new();
        goal.Start();
    }
}