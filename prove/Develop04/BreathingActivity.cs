using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity is meant to help you relax threw meditation. Clear your mind and focus on your breathing.")
    {
    }


    public override void RunActivity()
    {
        DisplayStartMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\n Breathe in...");
            ShowCountdown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.Write("\nBreath out...");
            ShowCountdown(4);
            elapsed += 4;
        }


        DisplayEndMessage();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}