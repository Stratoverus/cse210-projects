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
            Console.Write("What is your selection? ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
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
        //Need to calculate this better in the future using a foreach
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int i = 1;
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
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
        Console.Write("Which goal type do you want to create? ");
        string type = Console.ReadLine();
            //As of right now, I'm just using this to check if it's a valid answer. Might do more with this later.
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
            string amountString = Console.ReadLine();
            int amount = ConvertInt(amountString);
            Console.WriteLine("What is the bonus point value? ");
            string bonusString = Console.ReadLine();
            int bonus = ConvertInt(bonusString);
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

    public int ConvertInt(string number)
    {
        int converted = 0;
        if (int.TryParse(number, out int convert))
        {
            converted = convert;
            return converted;
        }
        else
        {
            Console.WriteLine("Not a valid input...");
            Thread.Sleep(2000);
            CreateGoal();
        }
        return converted;
    }

    public void RecordEvent()
    {
        ListGoalNames();
        bool inputValid = false;
        int index;
        while (!inputValid)
        {
            Console.Write("Which goal did you accomplish? ");
            string answer = Console.ReadLine();
            if (int.TryParse(answer, out index))
            {
                index -= 1;
                if (index >= 0 && index < _goals.Count)
                {
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine($"Invalid option! Please type a number from 1 to {_goals.Count}");
                }
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }
        

    }

    public void SaveGoals()
    {
        Console.Write("What would you like to save the file as? ");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file you wish to load from? ");
        string file = Console.ReadLine();
        //Just getting in barebones for now.
        String[] lines = System.IO.File.ReadAllLines(file);

        foreach (String line in lines)
        {
            string[] parts = line.Split("|");

            Goal goal = new(parts[0], parts[2], parts[3]);
            _goals.Add(goal);
        }
    }
}