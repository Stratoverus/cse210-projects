class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("You have already completed this. You need to record a different goal.");
            return 0;
        }
        _amountCompleted++;
        int pointsScored = base.RecordEvent();
        if (IsComplete())
        {
            Console.WriteLine($"Your goal was completed. You have earned {_bonus} bonus points.");
            pointsScored += _bonus;
        }
        return pointsScored;
    }

    public override bool IsComplete()
    {
        bool completed = false;
        if (_amountCompleted >= _target)
        {
            completed = true;
            return completed;
        }
        return completed;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{base.GetStringRepresentation()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}