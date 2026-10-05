using System;

class Program
{
    static void Main()
    {
        var produto = new Produto();
        produto.Nome = "Notebook";
        produto.Preco = 3000m;
        
        Console.WriteLine($"{produto.Nome} - R$ {produto.Preco}");
        
        produto.Preco = -500m; // tentativa inválida
        Console.WriteLine($"Após tentar setar -500: R$ {produto.Preco}");
        
        produto.AplicarDesconto(10m); // 10% de desconto
        Console.WriteLine($"Após 10% de desconto: R$ {produto.Preco}");
        
        produto.AplicarDesconto(150m); // inválido, não deve alterar
        Console.WriteLine($"Após tentar 150%: R$ {produto.Preco}");
        
        decimal precoComDesconto = produto.GetPrecoComDesconto(20m);
        Console.WriteLine($"Preco com 20% OFF (sem alterar original): R$ {precoComDesconto}");
        Console.WriteLine($"Preco original continua: R$ {produto.Preco}");
    }
}