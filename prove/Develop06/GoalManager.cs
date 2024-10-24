using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private int points = 0; 

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nPoints:{_score}");
            Console.WriteLine("\n1. Add Goal\n2. Record Event\n3. Display Goals\n4. Save Progress\n5. Load Progress\n6. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points:");
        points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.WriteLine("Enter target number of completions:");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points for completion:");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal added successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Goal goal = _goals.FirstOrDefault(g => g.GetDetailsString().Contains(name));

        if (goal != null)
        {
            goal.RecordEvent(points);
            _score += points;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Progress saved successfully.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string name = parts[0];
                    string description = parts[1];
                    points = int.Parse(parts[2]);
                    bool completed = bool.Parse(parts[3]);

                    Goal goal = null;

                    if (parts.Length == 4)
                    {
                        goal = new SimpleGoal(name, description, points);
                    }
                    else if (parts.Length == 5)
                    {
                        goal = new EternalGoal(name, description, points);
                    }
                    else if (parts.Length == 7)
                    {
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        goal = new ChecklistGoal(name, description, points, target, bonus)
                        {
                            AmountCompleted = amountCompleted,
                            Completed = completed
                        };
                    }

                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Progress loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved progress found.");
        }
    }
}
