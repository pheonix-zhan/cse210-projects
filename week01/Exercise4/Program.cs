using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("please type any number");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(" 0 can not be added to the list");
            }
            else
            {
                numbers.Add(number);
            }

        }

        float sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        double average = sum / numbers.Count;
        int largestNumber = -1;
        foreach (int n in numbers)
        {
            if (largestNumber < n)
            {
                largestNumber = n;
            }
            else
            {
                Console.WriteLine("The number is small");
            }
        }

        Console.WriteLine($"The total is {sum}");
        Console.WriteLine(numbers.Count);
        Console.WriteLine($"The average is {average} ");
        Console.WriteLine($"largest Number is {largestNumber}");

    }
}