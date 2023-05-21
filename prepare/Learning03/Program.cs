using System;

namespace Learning03{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03  Fraction !");
        Fraction fraction = new Fraction(4,3);
        string x = fraction.GetFractionString();
        Console.WriteLine(x);
        double y = fraction.GetFractionDouble();
        Console.WriteLine(y);
        
    }
}
}