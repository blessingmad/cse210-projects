using System;

public class Fraction

{
    private int _numerator;
    private int _denominator;

    public Fraction ()
    {
        private_numerator = 1;
        private_denominator = 1;
    }
    public Fraction (int wholeNumber)
    {
        _numerator = 5;
    }
    public Fraction (int numerator, int denomenator )
    {
        _numerator = numerator;
        _denominator = denomenator;
    }
    public GetNumerator()
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