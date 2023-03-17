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
        return  $"{_numerator}";

    }

    public string GetFractionString()
    {
        return $"{_numerator }/ {_denomenator}";
        
    }
    public double GetDecimalValue()
    { 
        return (double)_numerator / (double)_denominator;
    }




 

}