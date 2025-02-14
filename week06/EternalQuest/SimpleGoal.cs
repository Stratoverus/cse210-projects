class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("You have already completed this. You need to record a different goal.");
            return 0;
        }
       _isComplete = true;
       int pointsScored = base.RecordEvent();
       return pointsScored;
    }
    //For loading from the file
    public void markComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{base.GetStringRepresentation()}|{IsComplete()}";
    }
}