using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new("Keith Eberhard", "Calculus");
        Console.WriteLine(myAssignment.GetSummary());
        MathAssignment myMath = new("Keith Eberhard","Calculus","54", "1-20");
        Console.WriteLine(myMath.GetHomeworkList());
    }
}