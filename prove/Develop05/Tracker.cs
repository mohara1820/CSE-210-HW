using System;
using System.Collections.Generic;
using System.IO;

public class Tracker
{
    private List<Goal> _goals;
    private int _totalPoints;

    public Tracker()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordProgress(string goalName)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.GetDetails().Contains(goalName)) // Find the goal by name
            {
                if (goal is Checklist checklistGoal)
                {
                    if (checklistGoal.Completed())
                    {
                        _totalPoints += checklistGoal.RecordProgress();
                    }
                }
                else if (goal is Eternal eternalGoal)
                {
                    _totalPoints += eternalGoal.RecordProgress();
                }
                else if (goal is Simple simpleGoal)
                {
                    if (!simpleGoal.Completed())
                    {
                        simpleGoal.MarkComplete();
                        _totalPoints += simpleGoal.GetPoints();
                    }
                }
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetDetails());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _totalPoints = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                Console.WriteLine("Loaded Goal: " + lines[i]); // This will be replaced with goal creation logic
            }
        }
        else
        {
            Console.WriteLine("No saved file found.");
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}