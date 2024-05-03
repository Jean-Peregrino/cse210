public class Journal
{
    public List<Entry> _entries;


    public Journal()
    {
        _entries = new List<Entry>(); // Initialize list in constructor
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        

    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            entry .Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = File.AppendText(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}: {entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Clear existing entries before loading from file
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            string date = parts[0].Trim();
            string content = parts[1].Trim();
            _entries.Add(new Entry { _date = date, _entryText = content });
        }
        Console.WriteLine("Journal loaded from file successfully.");
    }

    public void WriteNewEntry()
    {
        Entry newEntry = new Entry();

        Console.WriteLine("Enter the date (e.g., YYYY-MM-DD): ");
        newEntry._date = Console.ReadLine();
        Console.WriteLine("Enter the content: ");
        newEntry._entryText = Console.ReadLine();

        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully.");
    }
}