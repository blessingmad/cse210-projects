using System;

public class Word

{
    private string _randomWord;
   

    public Word(string randomWord, string shown, string hidden)
    {
        _randomWord = randomWord;
        
    }
    public string GetSingleWord()
    {
        return _randomWord;
    }
  
    public string GetInfo()
    {
        return _randomWord ;
    }



}