using System;

public class Activity
{
private DateTime _activityDate;
    protected int _activityLengthMinutes;

    // Constructor to initialize the activity date and length
    public Activity(DateTime activityDate, int activityLengthMinutes)
    {
        _activityDate = activityDate;
        _activityLengthMinutes = activityLengthMinutes;
    }

    // Virtual methods to get distance, speed, and pace (to be overridden in derived classes)
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    // Method to get the summary of the activity
    public string GetSummary()
    {
        return $"{_activityDate:dd MMM yyyy} {GetType().Name} ({_activityLengthMinutes} min) - " + 
            $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}