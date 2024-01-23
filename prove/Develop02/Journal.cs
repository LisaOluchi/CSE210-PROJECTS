using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
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
                outputFile.WriteLine($"{entry.Date},{entry.Prompt},{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry loadedEntry = new Entry
            {
                Date = parts[0],
                Prompt = parts[1],
                EntryText = parts[2]
            };
            _entries.Add(loadedEntry);
        }
    }

    public void WriteNewEntry()
    {
        Entry newEntry = new Entry();
        newEntry.Date = DateTime.Now.ToShortDateString();
        newEntry.Prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {newEntry.Prompt}");
        Console.Write("Your Response: ");
        newEntry.EntryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
