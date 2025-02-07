//This is the mindfulness activity
//I went above and beyond by adding a new method that described their session and what they did.
using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to this relaxing program.");
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.Write("Type the number corresponding to the activity: ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                //Breathing Activity
                Console.Clear();
                BreathingActivity activity = new("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity.Run();
                valid = true;
            }
            else if (answer == "2")
            {
                //Listing Activity
                Console.Clear();
                ListingActivity activity = new("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity.Run();
                valid = true;
            }
            else if (answer == "3")
            {
                //Reflecting Activity
                Console.Clear();
                ReflectingActivity activity = new("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity.Run();
                valid = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Not a valid answer. Press enter to try again.");
                Console.ReadLine();
            }
        }
        

        
    }
}