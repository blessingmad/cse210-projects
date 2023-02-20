using System;

public class Fraction

{
    private int _numerator = 1 ;
    private int _denominator = 1 ;

    
    public Fraction (int numerator, int denomenator)
    {
        _numerator = numerator;
        _denominator = denomenator;
    }
    public string GetNumerator()
    {
        return  _numerator ;
    }
    public string GetFractionString()
    {
        string text = $"{_numerator} / {_denomenator}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }




 

}