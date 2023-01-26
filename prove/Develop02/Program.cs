using System;

class Program
{
    static void Main(string[] args)

    
    {
        Random randomGenerator = new Random();

        string _userPrompt = randomGenerator.Next(1, 5);

        int tap = 0;
        while (tap < 0)
        {
            Console.WriteLine("1. who");
            Console.WriteLine("2.where");
            Console.WriteLine("3.how");
            Console.WriteLine("4.when");
            Console.WriteLine("5.if");

            if (tap !> 0 )
            {
                 Console.WriteLine("1. who");
            }
            else if 
        }




        Journal myJournal = new Journal();


    }
}