using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        
        Console.WriteLine("Goals:");
        Console.WriteLine(".....");
        Console.WriteLine("1. Read Scriptures:");
        Console.WriteLine("2. Pass Sacament:");
        Console.WriteLine("3. Set Own Goals:");
        Console.WriteLine("....");

        Console.WriteLine("Which goal activity would you want to do?");

        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        string results = "";
        if (number == 1){
            results = "How long do you want to read for";
        }
        else if(number == 2)
        {
            results = "How many times do you want to pass the sacrament per month";
        }
        else if(number == 3)
        {
            results = "What goal do you want to set for yourself";
        }
        else
        {
            results = "invalid entry";
        }
        Console.WriteLine($"{results}");
        Console.ReadLine();



        //List<Goals> goals = new List<Goals>();
        //Goals g1 = new Goals('Reading Scripyures', )
        //Console.WriteLine("Hello Develop05 World!");
    }
}