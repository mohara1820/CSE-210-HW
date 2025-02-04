using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0; 
        Journal saveEntries = new Journal();

        do 
        {
            Console.WriteLine("Welcome to your personal electronic journal!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            // Improved input handling
            if (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;  // Go back to the menu
            }

            if (userInput == 1)
            {
                Prompt prompt1 = new Prompt();
                string firstPrompt = prompt1.Display();
                Console.WriteLine($"Here is your prompt: {firstPrompt}");
                string userEntry = Console.ReadLine();

                Entry e = new Entry();
                e._userPrompt = firstPrompt;
                e._dateTime = DateTime.Now.ToShortDateString();
                e._userEntry = userEntry;
                saveEntries._savedEntries.Add(e);
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Answers entered:");
                foreach (Entry e in saveEntries._savedEntries)
                {
                    e.Display();
                }
            }
            else if (userInput == 3)    
            {
                Console.Write("Please enter the file name: ");
                string name = Console.ReadLine();
                string filename = name + ".txt";
                saveEntries.NewJournalFromFile(filename);
            }
            else if (userInput == 4)
            {
                Console.Write("Please enter your file name: ");
                string name = Console.ReadLine();
                string filename = name + ".txt";

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry e in saveEntries._savedEntries)
                    {
                        outputFile.WriteLine($"{e._dateTime}~{e._userPrompt}~{e._userEntry}");
                    }
                }
                Console.WriteLine("Entries saved successfully.");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Exiting journal. Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }

        } while (userInput != 5);
    }
}