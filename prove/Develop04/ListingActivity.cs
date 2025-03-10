using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Animation _animation = new Animation();

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void RunActivity()
    {
        DisplayStartMessage();

        Random random = new Random();
        string selectedPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n{selectedPrompt}");
        Console.WriteLine("\nYou will have some time to think before listing...");
        _animation.ShowSpinner(5); 

        Console.WriteLine("\nStart listing items. Press Enter after each item:");

        List<string> userResponses = new List<string>();
        int elapsed = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
            }
            elapsed = (int)(DateTime.Now - endTime).TotalSeconds;
        }

        Console.WriteLine($"\nGreat job! You listed {userResponses.Count} items.");
        DisplayEndMessage();
    }
}