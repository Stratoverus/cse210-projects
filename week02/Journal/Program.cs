//This is my Journal Program
//I went above and beyond by adding a saved flag. If you try to exit when you haven't saved, the program will prompt and ask if you have saved first.
using System;
using System.Formats.Asn1;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    public static bool saved;
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Entry myEntry = new Entry();
        
        string option;
        saved = false;
        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Please select one of the following choices by typing the number:");
        option = "0";
        while (option != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            option = Console.ReadLine();
            if (option == "1")
            {
                
            }
            else if (option == "2")
            {

            }
            else if (option == "3")
            {

            }
            else if (option == "4")
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                Console.WriteLine("Saving...");

                saved = true;
            }
            else if (option == "5")
            {
                if (saved == false)
                {
                    Console.Write("You haven't saved to a file yet. All changes will be lost. Do you want to save to a file? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("Saving...");

                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Alright, closing without saving in a few seconds.");
                        System.Threading.Thread.Sleep(3000);
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("That wasn't a valid option. Saving anyways.");

                        System.Environment.Exit(1);
                    }
                }
                Console.WriteLine("Alright, closing without saving in a few seconds.");
                System.Threading.Thread.Sleep(3000);
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("That wasn't an option. Back to menu.");
                option = "0";
            }
        }
    }
}