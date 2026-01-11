using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the programme");
    }

    static string PromptUserName()
    {
        Console.Write("What is your user name");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("please enter you fav number");
        int FavNumber = int.Parse(Console.ReadLine());
        return FavNumber;
    }

    static int SquareNumber(int FavNumber)
    {
        int number = FavNumber * FavNumber;
        return number;
    }

    static void DisplayResult(int number, string userName)
    {
        Console.WriteLine($"{userName}, your square number is {number}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayMessage();



        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(squaredNumber, userName);


    }
}