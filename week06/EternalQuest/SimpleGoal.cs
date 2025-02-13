class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}