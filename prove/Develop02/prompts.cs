public class Prompt
{
    List<string> _newPrompts = new List<string>()
    {
        "what did you do today?", "How was the weather?", 
        "what did you do over the weekend?", "where you able to complete your homework?",
        "what was the high and low of your day?", "how did you notices god in your life today?"
    };

    public string Display()
    {
        Random randomPrompt= new Random();
        int randomIndex = randomPrompt.Next(_newPrompts.Count);
        string randomName =_newPrompts[randomIndex];
        return (randomName);

    }

}