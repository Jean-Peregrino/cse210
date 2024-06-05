using System;

public class Cycling : Activity
{
   private double _speed;

    // Constructor to initialize the cycling activity.
    public Cycling(DateTime activityDate, int activityLengthMinutes, double speed) : base(activityDate, activityLengthMinutes)
    {
        _speed = speed;
    }

    // Override methods to calculate speed, distance, and pace for cycling
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * (_activityLengthMinutes / 60.0); // Distance in kilometers
    }

    public override double GetPace()
    {
        return 60.0 / _speed; // Pace in minutes per kilometer
    }
}