using System.Runtime.CompilerServices;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplaystartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("Please enter the number of seconds you would like: ");
        _duration = int.Parse(Console.ReadLine()); // sets duration
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animations = new List<string> {"|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(animations[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;
            if(i>=animations.Count)
            {
                i=0;
            }
        }       

        // foreach (string a in animations)
        // {
        //     Console.Write(a);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
    }
    public void showCountdown(int seconds)
    {
        // 
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}