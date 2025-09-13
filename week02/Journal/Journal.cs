using System;
using System.Collections.Generic;
using System.IO;
public class Journal

//Display the journal 
//-Iterate through all entries in the journal and display them to the screen.
{
    public List<Entry> _entries { get; set; }

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll_entries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    //Save the journal to a file - Prompt the user for a filename and then save the current journal 
    // (the complete list of entries) to that file location.
    public void SaveToFile(string file_name)
    {
        using (StreamWriter file = new StreamWriter(file_name))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    //Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file.
    //This should replace any entries currently stored the journal.
    public void LoadFromFile(string file_name)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file_name);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry newEntry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(newEntry);

            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}