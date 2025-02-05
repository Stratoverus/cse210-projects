using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new("Keith Eberhard", "Programming");
        Console.WriteLine(myAssignment.GetSummary());
    }
}