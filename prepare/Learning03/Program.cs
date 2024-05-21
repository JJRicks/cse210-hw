using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction0 = new Fraction();
        Console.WriteLine(fraction0.getTop());
        Console.WriteLine(fraction0.getBottom());
        Console.WriteLine(fraction0.GetDecimalValue());
        Console.WriteLine(fraction0.GetFractionString());


        Fraction fraction1 = new Fraction(2);
        Console.WriteLine(fraction1.getTop());
        Console.WriteLine(fraction1.getBottom());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());

        Fraction fraction2 = new Fraction(5, 6);
        Console.WriteLine(fraction2.getTop());
        Console.WriteLine(fraction2.getBottom());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());

    }


}