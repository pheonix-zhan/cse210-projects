using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class Breathing : Activity
{
    public Breathing() : base ("Breathing", "we are going to relax together on the so as to relieve your stress", 0)
    {
        
    }
    public void Run()
    {
        DisplaystartingMessage();
        Console.WriteLine("This exercise is going to help you relax by helping you breath in and out ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in....");
            showCountdown(3);

            Console.WriteLine("Breath out....");
            showCountdown(3);
        }
        DisplayEndMessage();
    }
}