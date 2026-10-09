using System;
using System.Collections.Generic;

class CarrinhoDeCompras
{
    // Sua implementação vai aqui

    private List<Item> _itens = new List<Item>();

    public void AdicionarItem(Item item)
    {
        _itens.Add(item);
    }

    public int GetQuantidadeTotalDeProdutos()
    {
        int totalQuantidade = 0;
        foreach (var item in _itens)
        {
            totalQuantidade += item.Quantidade;
        }
        return totalQuantidade;
    }

    public decimal GetTotal()
    {
        decimal total = 0m;
        foreach (var item in _itens)
        {
            total += item.GetSubtotal();
        }
        return total;
    }
}