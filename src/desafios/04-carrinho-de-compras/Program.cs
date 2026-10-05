using System;

class Program
{
    static void Main()
    {
        var carrinho = new CarrinhoDeCompras();
        
        var item1 = new Item { Nome = "Mouse", PrecoUnitario = 80m, Quantidade = 2 };
        var item2 = new Item { Nome = "Teclado", PrecoUnitario = 150m, Quantidade = 1 };
        var item3 = new Item { Nome = "Monitor", PrecoUnitario = 1200m, Quantidade = 1 };
        
        carrinho.AdicionarItem(item1);
        carrinho.AdicionarItem(item2);
        carrinho.AdicionarItem(item3);
        
        Console.WriteLine($"Subtotal Mouse: R$ {item1.GetSubtotal()}");
        Console.WriteLine($"Subtotal Teclado: R$ {item2.GetSubtotal()}");
        Console.WriteLine($"Subtotal Monitor: R$ {item3.GetSubtotal()}");
        
        Console.WriteLine($"Quantidade total de produtos: {carrinho.GetQuantidadeTotalDeProdutos()}");
        Console.WriteLine($"Total do carrinho: R$ {carrinho.GetTotal()}");
    }
}