using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of activities with values in kilometers and kilometers per hour.
        var activities = new List<Activity>
        {
            new Running(DateTime.Parse("2024-06-04"), 20, 4.0), // Distance in kilometers
            new Cycling(DateTime.Parse("2024-06-04"), 40, 18.0), // Speed in km/h
            new Swimming(DateTime.Parse("2024-06-04"), 60, 60) // Number of laps
        };

        // Iterate through the list of activities and print the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }    
}