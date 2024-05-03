using System;
using System.Collections.Generic;
using System.IO;
 
class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
 
        while (true)
        {
            Console.WriteLine("Welcome to the Journal Program!!");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Please enter your choice: ");
            int menuChoice = int.Parse(Console.ReadLine());
 
            switch (menuChoice)
            {
                case 1:
                    myJournal.WriteNewEntry();
                    break;
 
                case 2:
                    myJournal.DisplayJournal();
                    break;
 
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;
 
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;
 
                case 5:
                Console.WriteLine("GoodBye");
                Environment.Exit(0);
                break;
 
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                    break;
       
            }
        } 
    }
}