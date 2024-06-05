using System;

public class Swimming : Activity
{
    private int _laps;

    // Constructor to initialize the swimming activity.
    public Swimming(DateTime activityDate, int activityLengthMinutes, int laps) : base(activityDate, activityLengthMinutes)
    {
        _laps = laps;
    }

    // Override methods to calculate distance, speed, and pace for swimming
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_activityLengthMinutes / 60.0); // Speed in km/h
    }

    public override double GetPace()
    {
        return _activityLengthMinutes / GetDistance(); // Pace in minutes per kilometer
    }
}