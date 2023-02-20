using System;

public class Reference

{
    private string _book;
    private int _chapter;
    private int _verse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public string GetAll()
    {
        return _book + _chapter + _verse;
    }
}