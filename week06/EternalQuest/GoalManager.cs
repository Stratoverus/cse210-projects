class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    private bool saved = false;
    public GoalManager()
    {

    }

    public void Start()
    {
        while (true)
        {
            //Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Please pick from one of the following options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Clear Terminal");
            Console.WriteLine("  7. Quit");
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
                    Console.Clear();
                    break;
                case "7":
                    CheckSaved();
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

    public void CheckSaved()
    {
        if (!saved)
        {
            Console.Write("You haven't saved yet. Do you want to save? (y/n) ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                SaveGoals();
                return;
            }
            else if (answer == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid answer, returning to main menu.");
                Start();
                return;
            }
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine();
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
        Console.WriteLine();
        Console.WriteLine("Here are your goals.");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals added yet, please add some...");
            Start();
        }
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
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
                    Start();
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
            Console.Write("How many times does this goal need to be accomplished for bonus points? ");
            string amountString = Console.ReadLine();
            int amount = ConvertInt(amountString);
            Console.Write("What is the bonus point value? ");
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
        else
        {
            Console.WriteLine("Not a valid input...");
            Thread.Sleep(2000);
            CreateGoal();
        }
        Start();
        saved = false;
        return;
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
        Console.WriteLine();
        ListGoalNames();

        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record events for...");
            Thread.Sleep(2000);
            Start();
            return;
        }
        bool inputValid = false;
        int index;
        while (!inputValid)
        {
            Console.Write("Which goal did you accomplish? ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(answer, out index))
            {
                index -= 1;
                if (index >= 0 && index < _goals.Count)
                {
                    int addPoints = _goals[index].RecordEvent();
                    _score += addPoints;
                    Console.WriteLine();
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
        saved = false;
    }

    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("What would you like to save the file as? ");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
        Console.WriteLine($"Your file has been saved as {file}.");
        saved = true;
    }

    public void LoadGoals()
    {
        Console.WriteLine();
        Console.WriteLine("NOTE: This will delete any goals that you have currently and load from this file.");
        Console.Write("What is the name of the file you wish to load from? ");
        string file = Console.ReadLine();
        if (!File.Exists(file))
        {
            Console.WriteLine("That file was not found. Please try again.");
            LoadGoals();
            return;
        }
        //Just getting in barebones for now.
        String[] lines = System.IO.File.ReadAllLines(file);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        //foreach won't work here because we're skipping the first line. Need to look into a for loop.
        //foreach (String line in lines)
        //{
        //    string[] parts = line.Split("|");
        //    Goal goal = new(parts[0], parts[2], parts[3]);
        //    _goals.Add(goal);
        //}
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            Goal goal;
            switch (parts[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(parts[1], parts[2], parts[3]);
                    if (bool.Parse(parts[4]))
                    {
                        //not sure how to save the bool from here... researching ways.
                        //Researched and found out about "down-casting" Seems good: https://www.csharp.com/article/polymorphism-up-casting-and-down-casting/
                        ((SimpleGoal)goal).markComplete(true);
                    }
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(parts[1], parts[2], parts[3]);
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    break;
                default:
                    //I think I'll just add some error handling in here just in case as default.
                    Console.WriteLine($"Error importing {parts[0]}");
                    continue;
            }
            _goals.Add(goal);
        }
        saved = true;
    }
}