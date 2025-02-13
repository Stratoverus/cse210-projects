using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square s1 = new(3, "Blue");

        Console.WriteLine($"The color is {s1.Getcolor()} and the area is {s1.GetArea()}.");
    }
}