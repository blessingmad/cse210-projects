using System;

public class Scripture

{
   private string _reference;
   private string _scripture; 

   public List<Scripture> scripture = new List<Scripture>(); 

   public Scripture()
   {
          _reference = "John 3:16";
          _scripture = "For God so loved the world, that hhe gave his only begotten Son that whosoever believeth in him should not perish, but have everlasting life";
   }
     {
          Console.WriteLine($ "{_scripture}");
          Console.writeLine();
          
     
     }
}