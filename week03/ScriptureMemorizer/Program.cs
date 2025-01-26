//Scripture memorize Program
//I went above and beyond by having there be a difficulty selector. AKA, Easy is 2 words hidden at a time, normal is 3, and hard is 4, with expert as 5.
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

// Scripture: And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, fi these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy ghost. And by the power of the Holy Ghost ye may know the truth of all things.

class Program
{ 
    static void Main(string[] args)
    {
        string scriptureText = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy ghost. And by the power of the Holy Ghost ye may know the truth of all things.";
        string scriptureBook = "Moroni";
        int scriptureChapter = 10;
        int startingVerse = 4;
        int endingVerse = 5;

        Reference myReference = new(scriptureBook, scriptureChapter, startingVerse, endingVerse);
        Scripture myScripture = new(myReference, scriptureText);
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


        while (myScripture.IsCompletelyHidden() == false) 
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            Console.ReadLine();
            myScripture.HideRandomWords(difficulty);            
        }
    }
}