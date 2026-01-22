public class Entry
{
    public string _DateTime;
    public string _promptText;
    public string _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_DateTime}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}