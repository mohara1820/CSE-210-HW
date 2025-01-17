using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string user_name = PromptUserName();
        int user_fav_number = PromptFavNumber();

        int numbered_squared = FavSquared(user_fav_number);

        DisplayResult(user_name, numbered_squared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptFavNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int FavSquared(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}