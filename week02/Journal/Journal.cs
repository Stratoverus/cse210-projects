using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        

    }

    public void DisplayAll()
    {
        Console.WriteLine("Displaying all entries in journal.");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            
        }
    }

    public void LoadFromFile(string file)
    {

    }
}