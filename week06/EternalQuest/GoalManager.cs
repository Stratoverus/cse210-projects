class GoalManager
{
    private List<Goal> _goals = new List<Goal> {};
    private int _score = 0;
    public GoalManager()
    {

    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Please pick from one of the following options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("What is your selection? ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That is not a valid answer, try again.");
                    Thread.Sleep(2000);
                    Start();
                    break;
            }   
        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of goals are as follows: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("Which goal type do you want to create? ");
        string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    //Simple Goal
                    
                    break;
                case "2":
                    //Eternal Goal

                    break;
                case "3":
                    //Checklist goal

                    break;
                default:
                    Console.WriteLine("That is not a valid answer, try again.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    CreateGoal();
                    break;
            }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}