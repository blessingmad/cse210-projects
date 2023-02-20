using System;

public class Scripture

{
   private string _reference;
   private string _scripture; 
   public Scripture(string reference, string scripture)
   {
          _reference = reference;
          _scripture = scripture;
   }
   public string GetReference()
   {
     return _reference;
   }
   public string GetScripture()
   {
     return _scripture;
   }
   public string GetVerseInfo()
   {
     return _reference + "-" + _scripture;
   }

}