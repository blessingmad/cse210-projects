using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*********************************");
        DateTime theCurrentDateTime = DateTime.Now;
        string dateText = theCurrentDateTime.ToLongDateString();
        Console.WriteLine($"{dateText}");
        Console.WriteLine("***********************************");
        Console.WriteLine("This Program helps individuals and or families to track and update the weekly scripture studies.");
        Console.WriteLine();
        Console.WriteLine("TOPICS");

        Console.WriteLine();
        Console.WriteLine("1. SACRIFICE");
        Console.WriteLine("2. FAITH");
        Console.WriteLine("3. OBEDIENCE");
        Console.WriteLine("4. SHARING");
        Console.WriteLine("5. TEMPLES");
        Console.WriteLine("6. SABBATH DAY");
        Console.WriteLine("7. FUNDS ");
        Console.WriteLine();

        Console.WriteLine("Choose one topic you what to study today by pressing one number (e.g, PRESS 2 TO STUDY ABOUT FAITH) ");
        Console.WriteLine();

        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        string results = "";
        if (number == 1)
        {
            results = "Share a story about someone's sacrifices that you are enjoying the blessings of and PRESS 1 to continue. ";
        }
        else if (number == 2)
        {
            results = " Faith ie either declining or growing. Discuss or ponder the meaning and PRESS 1 to continue.";
        }
        else if (number == 3)
        {
            results = "Exact Obedience. How is it possible and PRESS 1 to continue.";
        }
        else if(number ==4)
        {
            results = "How serving others increases your temporal and spiritual wellbeing and PRESS 1 to continue.";
        }
        else if (number ==5)
        {
            results = "Why do we need temples in our worshipping?. PRESS 1 to continue";
        }
        else if (number == 6)
        {
            results = "Which day is the sabbath day buddy? PRESS 1 to continue";
        }
        else if (number == 7)
        {
            results = "Funds and Stewardship. PRESS 1 to continue";
        }
        else if (number == 0 )
        {
            results = "GOOG--BYEE!!";
        }
        else
        {
            results = "invalid entry";
        }
        Console.WriteLine($"{results}");
        Console.WriteLine();

        Console.WriteLine("Pause and think about what you have read for a moment.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);
        while (DateTime.Now < endTime)
        {
            Console.Write("*");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("Well come back. Share what you have in mind.");
        
    }
}
