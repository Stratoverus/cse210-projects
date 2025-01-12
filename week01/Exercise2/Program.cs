using System;

class Program
{
    static void Main(string[] args)
    {
        //Get grade percentage from user
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int grade = int.Parse(response);


        string letter;
        //if statements to determine grade letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string modifier;

        if (grade <=93 && grade >=60)
        {
            int remainder = grade % 10;
            if (remainder >= 7)
            {
                modifier = "+";
            }
            else if (remainder < 3)
            {
                modifier = "-";
            }
            else
            {
                modifier = "";
            }
        }
        else 
        {
            modifier = "";
        }


        Console.WriteLine($"Your grade is {letter}{modifier}.");

        if (grade >= 70)
        {
            Console.WriteLine("You have passed. Congrats!");
        }
        else 
        {
            Console.WriteLine("You have failed. Better luck next time.");
        }
    }
}