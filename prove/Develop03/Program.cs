using System;
class   Program
{
    static void Main(string[] args)
    {   
        
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToLongDateString();
        Console.WriteLine($"{dateText}");

        Console.Write("For God so loved the world,that he gave his only begotten Son that whosoever believeth in him should not perish, but have everlasting life");
        string _scripture = Console.ReadLine();

        Reference myReference = new Reference();
        
    }
} 