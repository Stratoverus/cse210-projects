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
        Journal myJournal = new();
        

        saved = false;
        Console.WriteLine("Welcome to the Journal Program.");
        while (true)
        {
            Console.WriteLine("Please select one of the following choices by typing the number:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                myJournal.AddEntry();
                saved = false;
            }
            else if (option == "2")
            {
                myJournal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.WriteLine("What is the Filename");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }
            else if (option == "4")
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                Console.WriteLine("Saving...");
                myJournal.SaveToFile(file);
                saved = true;
            }
            else if (option == "5")
            {
                if (saved == false)
                {
                    Console.Write("You haven't saved to a file yet. All changes will be lost. Do you want to save to a file? (y/n) ");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.Write("What is the file name? ");
                        string file = Console.ReadLine();
                        Console.WriteLine("Saving...");
                        myJournal.SaveToFile(file);
                        saved = true;

                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Alright, closing.");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("That wasn't a valid option. Closing.");
                        System.Environment.Exit(1);
                    }
                }
                Console.WriteLine("Alright, closing.");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("That wasn't an option. Back to menu.");
            }
        }
    }
}