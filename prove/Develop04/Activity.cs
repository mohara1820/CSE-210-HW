using System;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private Animation _animation = new Animation();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration (seconds): ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Please enter a valid positive number.");
        }

        Console.WriteLine("\nGet ready...");
        _animation.ShowSpinner(3); 
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on {_name}.");
        _animation.ShowSpinner(3); 
    }

    public virtual void RunActivity()
    {
        DisplayStartMessage();
        DisplayEndMessage();
    }
}