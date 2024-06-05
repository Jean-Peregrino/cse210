using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Conference Blvd", "San Francisco", "CA", "USA");
        Address address2 = new Address("789 Party St", "Chicago", "IL", "USA");
        Address address3 = new Address("456 Garden Ave", "Miami", "FL", "USA");

        Lecture lecture1 = new Lecture("AI Revolution", "Exploring the future of AI", DateTime.Now.AddDays(10), new TimeSpan(9, 0, 0), address1, "Prof. Jane Doe", 150);
        Reception reception1 = new Reception("Corporate Gala", "An evening of networking and celebration", DateTime.Now.AddDays(20), new TimeSpan(19, 0, 0), address2, "gala.rsvp@company.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Beach Cleanup", "Community event to clean the beach", DateTime.Now.AddDays(30), new TimeSpan(8, 0, 0), address3, "Clear skies and sunny");

        Console.WriteLine("\nAI Revolution with Prof. Jane Doe");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture1.GetShortDescription());

        Console.WriteLine("\nCorporate Gala - An evening of networking and celebration");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception1.GetShortDescription());

        Console.WriteLine("\nBeach Cleanup - Community event to clean the beach");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorGathering1.GetShortDescription());
    }

}