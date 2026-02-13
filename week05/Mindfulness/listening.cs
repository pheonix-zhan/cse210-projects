using System.ComponentModel.Design;

public class Listening : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public Listening() : base ( "Listening", "This activity will help you reflect on the good things in your life by listing as many things as you can.", 0)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are the personal strengths of yours?");
        _prompts.Add("who are the people you have helped this week?");
        _prompts.Add("when have you felt the Holy Ghost this Month?");
        _prompts.Add("who are some of the people that give you courage to move on");
        
    }
    public void Run()
    {
        DisplaystartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompts:");
        // Console.WriteLine($"---{GetRandomprompt()}---");
        GetRandomprompt();
        Console.WriteLine("You may begin in:");

        showCountdown(5);

        GetListfromUser();

        Console.WriteLine($"You Listed {_count} items!");

        DisplayEndMessage();
    }
    public void GetRandomprompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        // return  _prompts[index];

    }
    public List<string> GetListfromUser()
    {
        List <string> item = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now <endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                item.Add(input);
                _count++;
            }
        }
        return item;
    }

}