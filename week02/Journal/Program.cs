using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to your Journal App!");

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Write a guided entry");
            Console.WriteLine("2. Write a free note");
            Console.WriteLine("3. Display all entries");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Load journal");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Guided entry
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine("Your response:");
                    string response = Console.ReadLine();

                    Entry guidedEntry = new Entry
                    {
                        _DateTime = DateTime.Now.ToString(),
                        _promptText = prompt,
                        _entryText = response
                    };
                    journal.AddEntry(guidedEntry);
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    // Free note
                    Console.WriteLine("Write your free note:");
                    string note = Console.ReadLine();

                    Entry freeEntry = new Entry
                    {
                        _DateTime = DateTime.Now.ToString(),
                        _promptText = "Free Note",
                        _entryText = note
                    };
                    journal.AddEntry(freeEntry);
                    Console.WriteLine("Note added!");
                    break;

                case "3":
                    // Display all entries
                    Console.WriteLine("\n--- Your Journal Entries ---");
                    journal.DisplayJournal();
                    break;

                case "4":
                    // Save journal
                    journal.savingFile();
                    break;

                case "5":
                    // Load journal
                    journal.loadingFile();
                    break;

                case "6":
                    // Exit
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
