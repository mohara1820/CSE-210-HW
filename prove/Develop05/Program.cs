using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Tracker goalTracker = new Tracker();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Goal Tracker!");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. View Goals");
            Console.WriteLine("4. View Total Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalTracker);
                    break;
                case "2":
                    RecordGoalProgress(goalTracker);
                    break;
                case "3":
                    goalTracker.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {goalTracker.GetTotalPoints()}");
                    break;
                case "5":
                    goalTracker.SaveToFile("goals.txt");
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "6":
                    goalTracker.LoadFromFile("goals.txt");
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    static void CreateGoal(Tracker goalTracker)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points awarded: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (type == "1")
        {
            newGoal = new Simple(name, description, points);
        }
        else if (type == "2")
        {
            newGoal = new Eternal(name, description, points);
        }
        else if (type == "3")
        {
            Console.Write("Enter target count for completion: ");
            int target = int.Parse(Console.ReadLine());
            newGoal = new Checklist(name, description, points, target);
        }

        if (newGoal != null)
        {
            goalTracker.AddGoal(newGoal);
            Console.WriteLine("Goal added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void RecordGoalProgress(Tracker goalTracker)
    {
        Console.Write("Enter the name of the goal to record progress: ");
        string goalName = Console.ReadLine();
        goalTracker.RecordProgress(goalName);
        Console.WriteLine("Progress recorded!");
    }
}