using System;

public class Resumes
{
    public string _names;

    public List<Jobs> _job = new List<Jobs>();

    public void Display()
    {
        Console.WriteLine($"Name: {_names}");
        Console.WriteLine("Jobs: ");

        foreach (Jobs jobs in _job)
        {
            jobs.Display();
        }
    }

}