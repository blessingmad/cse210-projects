using System;
class   Program
{
    static void Main(string[] args)



    {   
        
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToLongDateString();
        Console.WriteLine($"{dateText}");
      
   
        Console.WriteLine ("For God so loved the world, that he gave his only begotten Son that whosoever believeth in him should not perish, but have everlasting life");
        Console.WriteLine($"_sc");

        string _reference = Console.ReadLine();
        Scripture scripture1 = new Scripture();
       
        Reference myReference = new Reference();
        
        Word word = new Word(); 
    }
} 