using System;

class Program
{
    static void Main()
    {
        var conversor = new ConversorTemperatura();
        
        double c1 = 0;
        double c2 = 100;
        double c3 = 36.6;
        
        double f1 = conversor.CelsiusParaFahrenheit(c1);
        double f2 = conversor.CelsiusParaFahrenheit(c2);
        double f3 = conversor.CelsiusParaFahrenheit(c3);
        
        Console.WriteLine($"{c1}°C = {f1}°F");
        Console.WriteLine($"{c2}°C = {f2}°F");
        Console.WriteLine($"{c3}°C = {f3}°F");
    }
}