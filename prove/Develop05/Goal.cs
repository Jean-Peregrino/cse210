using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal (string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;

    }

    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} - {_description} - {(_isComplete ? "[x]" : "[ ]")}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public virtual void LoadDetails(string[] goalData)
    {
        _shortName = goalData[0];
        _description = goalData[1];
        _points = int.Parse(goalData[2]);
        _isComplete = bool.Parse(goalData[3]);
    }

}