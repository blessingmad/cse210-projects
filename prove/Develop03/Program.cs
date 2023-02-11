using System;
class   Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        scripture1._reference = 3;

        
        scripture1._scripture = "For God so loved the world,that he gave his only begotten Son that whosoever believeth in him should not perish, but have everlasting life";

        Reference myReference = new Reference();
        myReference._book = "John";
        myReference._chapter = 3;
        myReference._verse  = 16;
    }
} 