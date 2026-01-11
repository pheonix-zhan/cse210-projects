using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.WriteLine("What is the magic number?");
        // string magic = Console.ReadLine();
        //int magicNumber = int.Parse(magic);
        //Console.WriteLine(magicNumber);
        string response = "yes";
        while (response == "yes")
        {

            //if (response == "yes")

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);

            int guess = 0;
            

            while (guess != magicNumber)
            {
                Console.WriteLine("what is your guess?");
                guess = int.Parse(Console.ReadLine());
                int guessCount = guess + 1;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Guess lower please !");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("guess higher please");

                }
                else if (guess == magicNumber)
                {

                    Console.WriteLine("You have guessed !");
                    Console.WriteLine($"your guess count is {guessCount}");
                }


            }
            Console.WriteLine("Do you want to play again");
            response = Console.ReadLine();
        }



    }
}