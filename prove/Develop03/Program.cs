using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Scripture Memorization!");

        // Choose difficulty (Optional Feature)
        Console.Write("Choose a difficulty (1-Easy, 2-Medium, 3-Hard): ");
        int difficulty = int.Parse(Console.ReadLine());

string scriptureText = difficulty switch
{
    1 => "And my father dwelt in a tent",
    
    2 => "Counsel with the Lord in all thy doings, and he will direct thee for good;\n" +
         "yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep;\n" +
         "and when thou risest in the morning let thy heart be full of thanks unto God;\n" +
         "and if ye do these things, ye shall be lifted up at the last day.",
    
    3 => "Wo be unto him that shall say: We have received the word of God, and we need no more of the word of God,\n" +
         "for we have enough! For behold, thus saith the Lord God: I will give unto the children of men line upon line,\n" +
         "precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts,\n" +
         "and lend an ear unto my counsel, for they shall learn wisdom;\n" +
         "for unto him that receiveth I will give more; and from them that shall say, We have enough,\n" +
         "from them shall be taken away even that which they have.\n" +
         "Cursed is he that putteth his trust in man, or maketh flesh his arm, or shall hearken unto the precepts of men,\n" +
         "save their precepts shall be given by the power of the Holy Ghost.",
    
    4 => "Now behold, a marvelous work is about to come forth among the children of men.\n" +
         "Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength,\n" +
         "that ye may stand blameless before God at the last day.\n" +
         "Therefore, if ye have desires to serve God ye are called to the work;\n" +
         "For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might,\n" +
         "the same layeth up in store that he perisheth not, but bringeth salvation to his soul;\n" +
         "And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work.\n" +
         "Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence.\n" +
         "Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.",

    _ => "Invalid choice. Please restart and select 1-4." 
};

        Reference reference = new Reference("John", 11, 35);
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main loop
        while (!scripture.IsCompletelyHidden())
        {
            scripture.Display();

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideWords();
        }

        Console.WriteLine("All words are hidden. Well done!");
    }
}