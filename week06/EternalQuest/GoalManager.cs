using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // -------------------
    // Create new goal
    // -------------------
    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.WriteLine("Goal created!\n");
    }

    // -------------------
    // List goals
    // -------------------
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.\n");
            return;
        }

        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine();
    }

    // -------------------
    // Record event
    // -------------------
    public void RecordEvent()
    {
        DisplayGoals();

        if (_goals.Count == 0) return;

        Console.Write("Select goal number to record event: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.\n");
            return;
        }

        Goal goal = _goals[choice - 1];
        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.\n");
    }

    // -------------------
    // Display score + level
    // -------------------
    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Title: {GetTitle()}\n");
    }

    private string GetTitle()
    {
        if (_score < 1000) return "Novice";
        if (_score < 5000) return "Warrior";
        if (_score < 10000) return "Knight";
        return "Eternal Champion";
    }

    // -------------------
    // Save goals
    // -------------------
    public void SaveGoals(string filename)
    {
        List<string> lines = new List<string>();
        lines.Add($"Score:{_score}");
        foreach (Goal g in _goals)
        {
            lines.Add(g.GetStringRepresentation());
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine($"Goals saved to {filename}\n");
    }

    // -------------------
    // Load goals
    // -------------------
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = 0;

        foreach (string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Substring(6));
            }
            else
            {
                string[] parts = line.Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[2]);
                        SimpleGoal sg = new SimpleGoal(parts[1], "", int.Parse(parts[2])); // Adjust points if needed
                        if (isComplete) sg.RecordEvent(); // Mark as complete
                        _goals.Add(sg);
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], "", 100)); // Default points
                        break;

                    case "ChecklistGoal":
                        int completed = int.Parse(parts[2]);
                        ChecklistGoal cg = new ChecklistGoal(parts[1], "", 50, 5, 500); // Default values
                        for (int i = 0; i < completed; i++) cg.RecordEvent();
                        _goals.Add(cg);
                        break;
                }
            }
        }

        Console.WriteLine($"Goals loaded from {filename}\n");
    }
}
