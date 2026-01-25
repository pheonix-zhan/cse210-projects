using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions f = new Fractions();
        Fractions f2 = new Fractions(6);
        Fractions f1 = new Fractions(6,7);
        
        // f.DisplayFraction();
        // f2.DisplayFraction();
        // f1.DisplayFraction();
        f.SetTopNumber(2);
        Console.WriteLine(f.GetTopNumber());

        f.SetBottomNumber(3);
        Console.WriteLine(f.GetBottomNumber());

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());


        



        
    }
}