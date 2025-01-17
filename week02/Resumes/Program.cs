using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "QA Engineer";
        job2._company = "Early Warning";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Keith Eberhard";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}