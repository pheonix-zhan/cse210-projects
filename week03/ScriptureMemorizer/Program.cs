using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Game!");
        List<Scripture> scriptures = new List<Scripture>();
        string filePath = "scriptures.txt"; // Make sure this file exists in the project folder

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Each line: Book,Chapter,Verse,Text
                string[] parts = line.Split(',');

                if (parts.Length < 4)
                    continue; // Skip invalid lines

                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string text = parts[3];

                Reference reference = new Reference(book, chapter, verse);
                Scripture scriptre = new Scripture(reference, text);
                scriptures.Add(scriptre);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading scriptures: " + ex.Message);
            return; // Exit program if file loading fails
        }

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in the file.");
            return;
        }
        // Creating a Reference
        Reference john316 = new Reference("John", 3, 16);

        //  Creating a Scripture object
        string verseText = "For God so loved the world";
        Scripture scripture = new Scripture(john316, verseText);

        Random rnd = new Random();

        //while game loop 
        while (!scripture.IsCompletelyHidden())
        {
            // Display current state of the verse
            Console.WriteLine(scripture.GetDisplayText());

            // Decide how many words to hide this round (random 1–2 words for example)
            int wordsToHide = rnd.Next(1, 3);

            // Hide some words
            scripture.HideRandomWords(wordsToHide);

            // Wait for user input to continue
            Console.WriteLine("Press Enter to hide more words...");
            Console.ReadLine();
        }

        // All words are hidden
        Console.WriteLine("All words are hidden! Memorization complete!");
    }
}
