using System;
using System.Collections.Generic;

// activity counter option added
// Logic is implemented to ensure that all prompts/questions are used at least once before repeating.
class Program
{
    static Dictionary<string, int> activityCounts = new Dictionary<string, int>()
    {
        { "Breathing", 0 },
        { "Reflecting", 0 },
        { "Listing", 0 },
    };


    static void Main(string[] args)
    {
       
        while(true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. View activity counts");
            Console.WriteLine(" 5. Exit");  
            Console.Write("\nSelect a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 5)
            {
                Console.WriteLine("");
                Environment.Exit(0);
            }
            if (menuChoice == 4)
            {
                Console.WriteLine("Activity Counts: ");
                foreach (var entry in activityCounts)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} times");
                }
                continue;
            }



            Console.WriteLine("");
            Console.Write("How long, in seconds, would you like for your session? ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Activity activity = null;

            switch (menuChoice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out.", duration);
                    activityCounts["Breathing"]++;

                    break;

                case 2:
                    activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
                    activityCounts["Reflecting"]++;
                    break;

                case 3:
                    activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                    activityCounts["Listing"]++;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                    break;
            } 

            activity?.Run(); 
        }
    }
}
