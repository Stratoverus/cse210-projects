class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        int pointsScored = base.RecordEvent();
        return pointsScored;
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{base.GetStringRepresentation()}";
    }
}