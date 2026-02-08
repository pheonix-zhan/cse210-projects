public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _question = new List<string>();

    public Reflecting() : base("reflecting", "we take time to think about what we do our lives and how it has impacted on us")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _question.Add("Why was this experience meaningful to you?");
        _question.Add("Have you ever done anything like this before?");
        _question.Add("How did you get started?");
        _question.Add("How did you feel when it was complete?");
        _question.Add("What made this time different than other times?");
        _question.Add("What could you learn from this experience?");
        _question.Add("How can you apply this in the future?");
    }
    public void Run()
    {
        DisplaystartingMessage();

        DisplayPrompt();

        Displayquestion();

        // Console.WriteLine(GetRandomPrompt());
        // Console.WriteLine();

        // DateTime endTime = DateTime.Now.AddSeconds(_duration);
        // while (DateTime.Now < endTime)
        // {
        //     Console.WriteLine();
        //     Console.WriteLine(GetRandomquestion());
        //     ShowSpinner(5);
        // }

        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        // Console.WriteLine(_prompts[index]);
        return _prompts[index];
    }
    public string GetRandomquestion()
    {
        Random random = new Random();
        int index = random.Next(_question.Count);
        return _question[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }
    public void Displayquestion()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(GetRandomquestion());
            ShowSpinner(5);
        }
    }
}