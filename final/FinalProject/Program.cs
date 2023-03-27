using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*********************************");
        Console.WriteLine();
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

        Console.WriteLine("Choose one topic you what to study today by pressing one number (e.g, PRESS 2 TO LEARN ABOUT FAITH ");
        Console.WriteLine();

        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        string results = "";
        if (number == 1)
        {
            results = "Share a story about someone's sacrifices that you are enjoying the blessings of . ";
        }
        else if (number == 2)
        {
            results = " Faith is either declining or growing. ";
        }
        else if (number == 3)
        {
            results = "Exact Obedience. How is it possible.";
        }
        else if(number ==4)
        {
            results = "How serving others increases your temporal and spiritual wellbeing.";
        }
        else if (number == 5)
        {
            results = "Why do we need temples in our worshipping?. ";
        }
        else if (number == 6)
        {
            results = "Which day is the sabbath day buddy? ";
        }
        else if (number == 7)
        {
            results = "Funds and Stewardship. ";
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

        Console.WriteLine("Ponder.");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);
        while (DateTime.Now < endTime)
        {
            Console.Write("*");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("Well come back. Share what you have in mind.");
        Console.WriteLine();

        List<Studies>  studies = new List<Studies>();
        Monday s1 = new Monday("John 4", "Read", "Done");
        studies.Add(s1);

        Tuesday s2 = new Tuesday("Moroni", "Sing", "Scoop");
        studies.Add(s2);

        Wednesday s3 = new Wednesday ("Peter 5", "Dance", "Party");
        studies.Add(s3);

        Thursday s4 = new Thursday("Alma 34", "Scoop", "Yes");
        studies.Add(s4);

        Friday s5 = new Friday("Mormon 10", "Nephi 2", "Money");
        studies.Add(s5);

        Suturday s6 = new Suturday("Daniel 13", "Eating", "Jumping");
        studies.Add(s6);

        Sunday s7 = new Sunday("James 5", "Kissing", "Bouwling");
        studies.Add(s7);

        foreach (Studies s in studies)
        {
            string standardStartingMessage = s.GetStartingMessage ();
            string scripture = s.GetScripture ();
            string summary = s.GetSummary ();

            Console.WriteLine($"{standardStartingMessage} {scripture} {summary}");

        }
        string respond = Console.ReadLine();
        int digit = int.Parse(respond);
        string output = "";
        if (digit == 1)
        {
            output = ("{s1}");
        }
        else {
            output = ("{S4}");
        }
        Console.WriteLine($"{output}");
        Console.WriteLine();

        
    }
}
