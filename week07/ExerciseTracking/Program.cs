using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity a1 = new("19 Feb 2025", 30, "Running", 3);
        a1.GetSummary();

        BicycleActivity a2 = new("19 Feb 2025", 60, "Bicycle", 10);
        a2.GetSummary();

        SwimmingActivity a3 = new("19 Feb 2025", 45, "Swimming", 8.5);
        a3.GetSummary();
    }
}