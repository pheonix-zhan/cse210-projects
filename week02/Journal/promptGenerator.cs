public class PromptGenerator
{


    public List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
       _prompts.Add("Write one word to explain the day you had?");
       _prompts.Add("What was highlight of your day?");
       _prompts.Add("Is there anything you would like to do differently if you had a chance?");
       _prompts.Add("What did you learn through out the day");
       _prompts.Add("Did you teach someone today?");
       _prompts.Add("What can you do to make tomorrow better?");
    }

    public string GetRandomPrompt()
    {

        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    


}