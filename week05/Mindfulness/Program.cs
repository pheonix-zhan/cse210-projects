using System;

class Program
{
    static void Main()
    {

        int breathingCount = 0;
        int reflectingCount = 0;
        int listeningCount = 0;

        //added statistic tracking feature that counts how many times an activity has been completed
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Statistics");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Breathing().Run();
                    breathingCount++;
                    break;

                case "2":
                    new Reflecting().Run();
                    reflectingCount++;
                    break;

                case "3":
                    new Listening().Run();
                    listeningCount++;
                    break;

                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Activity Statistics:");
                    Console.WriteLine($"Breathing completed: {breathingCount} times");
                    Console.WriteLine($"Reflecting completed: {reflectingCount} times");
                    Console.WriteLine($"Listing completed: {listeningCount} times");
                    Console.WriteLine("Press Enter to return to menu.");
                    Console.ReadLine();
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
