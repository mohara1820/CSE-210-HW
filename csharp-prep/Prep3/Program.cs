using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int chosen_Number = randomGenerator.Next(1,101);

        int guess_number = -1;

        while (guess_number != chosen_Number)
        {
            Console.Write("what is your guess on the number? ");
            guess_number = int.Parse(Console.ReadLine());

            if (chosen_Number > guess_number)
            {Console.WriteLine("Higher");}

            else if (chosen_Number < guess_number)
            {Console.WriteLine("Lower");}

            else 
            {Console.WriteLine("that is correct! good job!");}
        }
    }
}