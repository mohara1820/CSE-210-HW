using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers_list = new List<int>();

        int input_number =-1;
        while (input_number != 0)
        {
            Console.Write("Enter a number (type 0 to end/quit): ");

            string input_respone = Console.ReadLine();
            input_number = int.Parse(input_respone);

            if(input_number != 0)
            {numbers_list.Add(input_number);}
        }

//calculating the total sum
    int sum = 0;
    foreach (int number in numbers_list)
    {sum += number;}

    Console.WriteLine($"the total is: {sum}");
// totaling the numbers

    float average = ((float)sum) / numbers_list.Count;
    Console.WriteLine($"the average the list is: {average}");

//the max number

    int max_total = numbers_list[0];
    foreach (int number in numbers_list)
    {
        if (number > max_total)
        {max_total = number;}
    }
    Console.Write($"the largest number in the list is: {max_total}");

    }
}