using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToLongDateString();

        Console.WriteLine($" {dateText}");

        Console.Write("What is your percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        if (percent >= 90)

        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        if (percent >= 70)
        {
            Console.Write("Pass.");
        }
        else
        {
            Console.Write("Palesa.");
        }


    }
}