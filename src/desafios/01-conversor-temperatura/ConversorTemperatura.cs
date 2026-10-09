using System;

// TODO: Implemente a classe ConversorTemperatura aqui.
// Ela deve ter um método chamado CelsiusParaFahrenheit
// que recebe um double e retorna um double.
//
// Fórmula: F = C * 1.8 + 32
//
// Exemplo de uso (já está no Program.cs):
//   var conversor = new ConversorTemperatura();
//   double f = conversor.CelsiusParaFahrenheit(100); // deve retornar 212

class ConversorTemperatura
{
    // Sua implementação vai aqui
    public double CelsiusParaFahrenheit(double celsius)
    {
        return celsius * 1.8 + 32;
    }
}