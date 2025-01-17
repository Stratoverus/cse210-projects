using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2024;
        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "QA Engineer";
        job2._company = "Early Warning";
        job2._startYear = 2021;
        job2._endYear = 2022;
        Console.WriteLine(job2._company);


    }
}