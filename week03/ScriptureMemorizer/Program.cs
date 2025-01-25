//Scripture memorize Program
//I went above and beyond by having there be a difficulty selector. AKA, Easy is 2 words hidden at a time, normal is 3, and hard is 4, with expert as 5.
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{ 
    static void Main(string[] args)
    {
        Word myWord = new();
        Reference myReference = new();
        Scripture myScripture = new();
        Console.WriteLine("Please select your difficulty.");
        Console.WriteLine("Type either 1 for Easy, 2 for Normal, 3 for Hard, or 4 for expert. ");
        string choice = Console.ReadLine();
        int difficulty;
        //Easy difficulty
        if (choice == "1")
        {
            difficulty = 2;
        }
        //Normal Difficulty
        else if (choice == "2")
        {
            difficulty = 3;
        }
        //Hard Difficulty
        else if (choice == "3")
        {
            difficulty = 4;
        }
        //Expert Difficulty
        else if (choice == "4")
        {
            difficulty = 5;
        }
        else
        {
            Console.WriteLine("Not a valid selection, choosing normal");
            difficulty = 3;
        }
        

        while (true) 
        {
            Console.Clear();
            myScripture.GetDisplayText();

        }
    }
}