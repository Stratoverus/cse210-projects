//Youtube program
using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new();
        video1._title = "The Hunt for the BEST Controller";
        video1._author = "Linus Tech Tips";
        video1._length = 1488;
        video1._comments.Add("BocchiTheBox", "This is probably the best advertisement these controller companies never asked for.");
        video1._comments.Add("General_M", "I would have liked to see the Xbox Series and Dual Sense in the tier list just to see where they land compared to the third party options.");
        video1._comments.Add("Mthexgamer8240", "I would love to see more of this in the future, but with different peripherals, such as mouse, keyboard and headset.");

        Video video2 = new();
        video2._title = "The Second Punic War - OverSimplified (Part 3)";
        video2._author = "OverSimplified";
        video2._length = 2945;
        video2._comments.Add("Keith-mh1mt", "This trilogy deserves an IMDB score!");
        video2._comments.Add("chuckaviator6423", "What a life Hannibal lived, worthy of an epic movie");
        video2._comments.Add("hneditspot", "History's ability to spawn in an insane general whenever all hope was lost never ceases to amaze me ngl");

        Video video3 = new();
        video3._title = "Are Wolves Overpowered?";
        video3._author = "TierZoo";
        video3._length = 677;
        video3._comments.Add("ivanbluecool", "Wolf servers are filled with modders. Not sure why anyone would think a pug build would be useful for combat.");
        video3._comments.Add("hornedcat9950", "These wolves have better coordination than my ranked teammate");
        video3._comments.Add("craigrussell3062", "Pigs finally developed a defensive strategy against the wolf build with the Brick House upgrade");

        Console.WriteLine(video1.Display());
        Console.WriteLine(video2.Display());
        Console.WriteLine(video2.Display());
    }
}