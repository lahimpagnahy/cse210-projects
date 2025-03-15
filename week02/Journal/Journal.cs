using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.FormatForFile());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            foreach (string line in File.ReadLines(file))
            {
                _entries.Add(Entry.ParseFromFile(line));
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
