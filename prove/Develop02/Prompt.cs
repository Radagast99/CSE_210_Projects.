public class Prompt
{
    public List<string> _prompts = new List<string>() {
                        "Who was the most interesting person I interacted with today?", 
                        "What was the best part of my day?", 
                        "How did I see the hand of the Lord in my life today?", 
                        "What was the strongest emotion I felt today?", 
                        "If I had one thing I could do over today, what would it be?"};
        

    public Prompt()
    {
    }

    public string PromptRandom()
    {
        Entry passToEntry = new Entry();
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        passToEntry._prompt = _prompts[randomPrompt];
        Console.WriteLine(_prompts[randomPrompt]);
        return passToEntry._prompt;
    }
}