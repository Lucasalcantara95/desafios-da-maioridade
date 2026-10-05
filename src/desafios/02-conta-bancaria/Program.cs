using System;

class Program
{
    static void Main()
    {
        var conta = new ContaBancaria();
        conta.Titular = "Carlos";
        conta.Saldo = 1000m;
        
        Console.WriteLine($"Titular: {conta.Titular}");
        Console.WriteLine($"Saldo inicial: {conta.Saldo}");
        
        bool saque1 = conta.Sacar(300m);
        Console.WriteLine($"Saque de 300: {saque1} | Saldo: {conta.Saldo}");
        
        bool saque2 = conta.Sacar(2000m);
        Console.WriteLine($"Saque de 2000: {saque2} | Saldo: {conta.Saldo}");
        
        conta.Depositar(500m);
        Console.WriteLine($"Após depósito de 500: {conta.Saldo}");
    }
}