using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("...................................");
        Console.WriteLine("Author: Blessing Madhuma");
        Console.WriteLine("..................................");
        DateTime theCurrentDateTime = DateTime.Today;
        string dateText = theCurrentDateTime.ToLongDateString();
        Console.WriteLine($"{dateText}");
        Console.WriteLine();
        Console.WriteLine("Which activity would you what to take, Press 1 for BREATHING, 2 for REFLECTION and 3 for LISTING");
        Console.WriteLine();

        
        Console.WriteLine("1. Breath Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("0. Quit");
        Console.WriteLine();

        Console.WriteLine("What do you want to do:");
        //Console.ReadLine();
        
        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        string results = "";
        if(number == 1)
        {
            results = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else if(number == 2)
        {
            results = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if(number ==3)
        {
            results = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
        else if(number == 0)
        {
            results = "GODBYE!!!!";
        }
        else
        {
            results = "invalid entry";
        }
        Console.WriteLine($"{results}");
        Console.WriteLine();

        Console.WriteLine("How many seconds do you want to spend on this activity");
        Console.ReadLine();

        // pause the program
        Console.WriteLine("Going to sleep for a second...");
        Console.WriteLine();
        List<string> animationString = new List<string>();
        animationString.Add("*");
        animationString.Add("#");
        animationString.Add(".");
        animationString.Add("$");

        foreach(string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        // same thing as above.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(12);
        while(DateTime.Now < endTime)
        {
            Console.Write("*");
            Thread.Sleep (1000);
        }

        //Activity a1 = new Activity("How many seconds do you want to spend on this activity","2. Reflect", "3. Listing");
        //Console.WriteLine(a1.GetDetails());



        Console.WriteLine("I'am back");
        

        BreathActivity act1 = new BreathActivity("This program helps you to keep track of your activities","Hold your breath", "Breath In",".", "Breath out");
        Console.WriteLine(act1.GetActivityDiscription());
        
        ReflectionActivity act2 = new ReflectionActivity("Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.","Have you ever done anything like this before", "Why was this experience meaningful to you?");
        Console.WriteLine(act2.GetReflection());
        List<string> reflectionString = new List<string>();
        reflectionString.Add("Why was this experience meaningful to you?");
        reflectionString.Add("Have you ever done anything like this before?");
        reflectionString.Add("How did you get started?");
        reflectionString.Add("How did you feel when it was complete?");
        reflectionString.Add("What made this time different than other times when you were not as successful?");
        reflectionString.Add("What is your favorite thing about this experience?");
        reflectionString.Add("What could you learn from this experience that applies to other situations?");
        reflectionString.Add("What did you learn about yourself through this experience?");
        reflectionString.Add("How can you keep this experience in mind in the future?");
        




        ListingActivity act3 = new ListingActivity("Who are people that you appreciate?", "What are personal strengths of yours?", "When have you felt the Holy Ghost this month?","Who are people that you have helped this week?");
        Console.WriteLine(act3.GetList());



    }
} 