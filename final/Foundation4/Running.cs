using System;

public class Running : Activity
{
    private double _distance;

    // Constructor to initialize the running activity
    public Running(DateTime activityDate, int activityLengthMinutes, double distance) : base(activityDate, activityLengthMinutes)
    {
        _distance = distance;
    }

    // Override methods to calculate distance, speed, and pace for running
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _activityLengthMinutes * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return _activityLengthMinutes / _distance; // Pace in minutes per kilometer
    }
}