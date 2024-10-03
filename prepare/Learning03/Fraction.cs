using System;

public class Fraction
{
    
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
      W03 Prepare: Learning Activity*/
    
    // Private attributes for the numerator (top) and denominator (bottom)
    private int _top;
    private int _bottom;

    // Default constructor initializes the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that takes a whole number (e.g., 5 -> 5/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that takes a numerator (top) and a denominator (bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Getter and setter for the numerator (top)
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and setter for the denominator (bottom)
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
