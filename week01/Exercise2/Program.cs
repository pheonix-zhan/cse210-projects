using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("what is your grade please");
        string grades = Console.ReadLine();
        Console.WriteLine($"{grades}");
        int number = int.Parse(grades);
        Console.Write(number);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }
        else
        {
            Console.Write("This Mark is not part of the system");
        }
        Console.WriteLine(letter);


        if (number >= 70)
        {
            Console.WriteLine("Congratulations, You have made it");
        }

        else
        {
            Console.WriteLine("You can make it, i believe in you. Try again and do not give up");
        }

    }
}