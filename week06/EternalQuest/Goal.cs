class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        string complete = " ";
        if (IsComplete())
        {
            complete = "X";
        }
        return $"[{complete}] {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}