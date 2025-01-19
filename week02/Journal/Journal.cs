using System;
using System.ComponentModel;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new();
    PromptGenerator prompt = new();

    public void AddEntry()
    {
        string myPrompt = prompt.GetRandomPrompt();
        Console.WriteLine(myPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        Entry entry = new(myPrompt, response);
        _entries.Add(entry);
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
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        String[] lines = System.IO.File.ReadAllLines(file);

        foreach (String line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new(parts[0], parts[1], parts[2]);
            _entries.Add(entry);
        }
    }
}