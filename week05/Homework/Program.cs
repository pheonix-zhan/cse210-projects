using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment();
        assignment.SetstudentName("Nankya");
        assignment.settopic("Integer");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");

        Math assignment1 = new Math();
        assignment1.SetstudentName("Sandra");
        assignment1.settopic("Fractions");
        assignment1.SetProblem("Problems1-5");
        assignment1.SettextbookSection("1.2");
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());
        Console.WriteLine("");

        Writing assignment2 = new Writing();
        assignment2.SetstudentName("Xiao");
        assignment2.settopic("Quads");
        assignment2.SetTitle("The Wonder of the Lord");
        
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingList());

        //  //  creating  the derived class assignment
        // Math assignment4 = new Math("Xiao Zhan", "Integers", "2.3", "8-9");
        // Console.WriteLine(assignment4.GetSummary());
        // Console.WriteLine(assignment4.GetHomeworkList());

    }
}