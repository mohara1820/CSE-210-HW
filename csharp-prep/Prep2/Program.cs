using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?: ");
        string answer = Console.ReadLine();
        int grade_percent = int.Parse(answer);

        string letter = "";

        if (grade_percent >= 90)
        { letter = "B"; }

        else if (grade_percent >= 80)
        { letter = "B"; }

        else if (grade_percent >= 70)
        { letter = "C"; }

        else if (grade_percent >= 60)
        { letter = "D"; }

        else
        { letter = "F"; }

        Console.WriteLine($"Your Grade is {letter}");

        if (grade_percent>= 70)
        {Console.WriteLine("You passed!");}
        else
        {Console.WriteLine("Well you can't win them all, study more and try again");}
    }
}