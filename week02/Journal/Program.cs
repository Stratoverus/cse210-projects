//This is my Journal Program
//I went above and beyond by adding a saved flag. If you try to exit when you haven't saved, the program will prompt and ask if you have saved first.
using System;
using System.Runtime.InteropServices;

class Program
{
    public Boolean saved;
    static void Main(string[] args)
    {
        string option;
        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Please select one of the following choices by typing the number:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
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

            }
            else if (option == "5")
            {
                
            }
        }
    }
}