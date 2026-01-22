using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entrys = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entrys.Add(newEntry);
    }

    // Display all entries
    public void DisplayAll()
    {
        foreach (Entry e in _entrys)
        {
            e.DisplayEntry();
        }
    }

    // Optional wrapper
    public void DisplayJournal()
    {
        DisplayAll();
    }

    // Save journal to a text file
    public void savingFile()
    {
        Console.WriteLine("Enter the filename to save your journal:");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry e in _entrys)
                {
                    // Format: Date|Prompt|EntryText
                    string line = $"{e._DateTime}|{e._promptText}|{e._entryText}";
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file: " + ex.Message);
        }
    }

    // Load journal from a text file
    public void loadingFile()
    {
        Console.WriteLine("Enter the filename to load your journal:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        try
        {
            _entrys.Clear(); // Clear existing entries before loading
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                // Expecting format: Date|Prompt|EntryText
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry e = new Entry
                    {
                        _DateTime = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entrys.Add(e);
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading file: " + ex.Message);
        }
    }
}
