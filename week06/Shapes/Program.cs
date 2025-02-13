using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        
        Square s1 = new(3, "Blue");
        shapes.Add(s1);

        Rectangle s2 = new(4, 5, "red");
        shapes.Add(s2);

        Circle s3 = new(4, "purple");
        shapes.Add(s3);
            
        Console.WriteLine($"The color is {s1.Getcolor()} and the area is {s1.GetArea()}.");


    }
}