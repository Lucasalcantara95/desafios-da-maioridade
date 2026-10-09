using System;
using System.Reflection.Metadata.Ecma335;

// TODO: Implemente a classe ContaBancaria aqui.
//
// Ela deve ter:
// - Propriedade Titular (string)
// - Propriedade Saldo (decimal)
// - Método Depositar(decimal valor) que adiciona ao saldo
// - Método Sacar(decimal valor) que:
//     * Se saldo >= valor: subtrai e retorna true
//     * Se saldo < valor: não altera nada e retorna false
//
// Exemplo de uso (já está no Program.cs):
//   var conta = new ContaBancaria();
//   conta.Titular = "Carlos";
//   conta.Saldo = 1000m;
//   bool ok = conta.Sacar(300m); // deve retornar true e saldo vira 700

class ContaBancaria
{
    // Sua implementação vai aqui
    public string? Titular {get; set;}

    public decimal Saldo {get; set;}


    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }


    public bool Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return true;
        }

        return false;
    }

}