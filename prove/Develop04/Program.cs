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

        //Activity a1 = new Activity("How many seconds do you want to spend on this activity","2. Reflect", "3. Listing");
        //Console.WriteLine(a1.GetDetails());

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

        Console.WriteLine("How many seconds do you want to spend on this activity");
        Console.ReadLine();
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(20000);
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b\b");
        Console.Write("-");


        Console.WriteLine("I'am back");
        

        BreathActivity act1 = new BreathActivity("Breath Out","Hold your breath", "Breath In","mm");
        Console.WriteLine(act1.GetActivityDiscription());

        ReflectionActivity act2 = new ReflectionActivity("who", "when",",", "why","sure", "when");
        Console.WriteLine(act2.GetReflection());

        ListingActivity act3 = new ListingActivity("0n3", "tw0", "three","www");
        Console.WriteLine(act3.GetList());



    }
} 