using System;

class Program
{
    static void Main(string[] args)
    {
        //First overall summary here
        Assignment m1 = new("Keith Eberhard", "Programming");
        Console.WriteLine(m1.GetSummary());

        //Second assignment
        MathAssignment m2 = new("Keith Eberhard","Calculus","54", "1-20");
        Console.WriteLine(m2.GetSummary());
        Console.WriteLine(m2.GetHomeworkList());

        //Third assignment
        WritingAssignment m3 = new("Keith Eberhard", "English 1010", "To kill a Mockingbird by somebody");
        
    }
}