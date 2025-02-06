//This is the mindfulness activity
//I went above and beyond by....
using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to this relaxing program.");
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.Write("Type the number corresponding to the activity: ");
            //Gonna try this here. https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                //Breathing Activity
                valid = true;
            }
            else if (answer == 2)
            {
                //Listing Activity
                valid = true;
            }
            else if (answer == 3)
            {
                //Reflecting Activity
                valid = true;
            }
            else
            {
                Console.WriteLine("Not a valid answer. Press any key to try again.");
                Console.ReadLine();
            }
        }
        

        
    }
}