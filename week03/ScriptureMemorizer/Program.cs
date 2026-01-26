using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Game!");

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
