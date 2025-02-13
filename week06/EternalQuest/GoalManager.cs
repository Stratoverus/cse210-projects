class GoalManager
{
    private List<Goal> _goals = new();
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
        Console.WriteLine($"You have {_score} points.");
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
        string type = Console.ReadLine();

            switch (type)
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
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of this goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        if (type == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for bonus points? ");
            string amount = Console.ReadLine();
            Console.WriteLine("What is the bonus point value? ");
            string bonus = Console.ReadLine();
            ChecklistGoal g = new(name, description, points, amount, bonus);
            _goals.Add(g);
        }
        else if (type == "2")
        {
            EternalGoal g = new(name, description, points);
            _goals.Add(g);
        }
        else if (type == "1")
        {
            SimpleGoal g = new(name, description, points);
            _goals.Add(g);
        }
        Start();
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