using System;

class Program
{ 
    static void Main(string[] args)

 
        
    { 
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        

        Console.Write("what is your first name:");
        string first = Console.ReadLine();

        Console.Write("What is your last name:");
        string last = Console.ReadLine();
        Console.WriteLine($"{dateText}");
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}   
