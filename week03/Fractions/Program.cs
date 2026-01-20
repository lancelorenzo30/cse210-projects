using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction sample1 = new Fraction();
        Console.WriteLine(sample1.GetFractionString());
        Console.WriteLine(sample1.GetDecimalValue());

        Fraction sample2 = new Fraction(5);
        Console.WriteLine(sample2.GetFractionString());
        Console.WriteLine(sample2.GetDecimalValue());

        Fraction sample3 = new Fraction(3,4);
        Console.WriteLine(sample3.GetFractionString());
        Console.WriteLine(sample3.GetDecimalValue());

        Fraction sample4 = new Fraction(1,3);
        Console.WriteLine(sample4.GetFractionString());
        Console.WriteLine(sample4.GetDecimalValue());
    }
}