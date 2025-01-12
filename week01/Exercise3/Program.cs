using System;

class Program
{
    static void Main(string[] args)
    {
        
        string answer = "yes";
        while (answer == "yes")
        {
            
            //Console.Write("What is the magic number? ");
            //string magic = Console.ReadLine();
            //int magicnum = int.Parse(magic);
            Random randomGenerator = new Random();
            int magicnum = randomGenerator.Next(1,100);

            int guesscount = 0;
            int guessnum = 0;
            while (guessnum != magicnum)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessnum = int.Parse(guess);

                if (guessnum > magicnum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessnum < magicnum)
                {
                    Console.WriteLine("Higher");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }
                guesscount ++;
            }
            Console.WriteLine($"It took you {guesscount} tries");

            Console.Write("Do you want to play again? (yes/no) ");
            answer = Console.ReadLine();
        }
    }
}