using System;

// TODO: Implemente a classe Item aqui.
//
// Ela deve ter:
// - Propriedade Nome (string)
// - Propriedade PrecoUnitario (decimal)
// - Propriedade Quantidade (int)
// - Método GetSubtotal() que retorna PrecoUnitario * Quantidade
//
// Exemplo de uso (já está no Program.cs):
//   var item = new Item { Nome = "Mouse", PrecoUnitario = 80m, Quantidade = 2 };
//   decimal subtotal = item.GetSubtotal(); // deve retornar 160

class Item
{
    // Sua implementação vai aqui
    public string? Nome {get; set;}

    public decimal PrecoUnitario {get; set;}

    public int Quantidade {get; set;}


    public decimal GetSubtotal()
    {
        return PrecoUnitario * Quantidade;
    }
}