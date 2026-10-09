using System;

// TODO: Implemente a classe Produto aqui.
//
// Ela deve ter:
// - Propriedade Nome (string)
// - Propriedade Preco (decimal) com validação:
//     * Se tentarem setar valor negativo, o preço NÃO muda
//     * Dica: use um backing field (_preco) e um set customizado
// - Método AplicarDesconto(decimal percentual):
//     * Reduz o preço em percentual% (ex: 10 = 10%)
//     * Se percentual < 0 ou > 100, não faz nada
// - Método GetPrecoComDesconto(decimal percentual):
//     * Retorna o preço após o desconto, SEM alterar o preço original
//     * Mesma validação de percentual do AplicarDesconto
//
// Exemplo de uso (já está no Program.cs):
//   var produto = new Produto();
//   produto.Preco = 3000m;
//   produto.Preco = -500m; // preço continua 3000
//   produto.AplicarDesconto(10m); // preço vira 2700

class Produto
{
    // Sua implementação vai aqui

    public string? Nome { get; set; }
    private decimal _preco { get; set; }

    public decimal Preco
    {

        get { return _preco; }
        set
        {
            if (value >= 0m)
            {
                _preco = value;
        }
        }
    }


    public void AplicarDesconto(decimal percentual)
    {
        if (percentual >= 0m && percentual <= 100m)
        {
            _preco = _preco - (_preco *(percentual /100m));
        }
    }



    public decimal GetPrecoComDesconto (decimal percentual)
    {
        if (percentual >= 0m && percentual <= 100m)
        {
            return _preco - (_preco *(percentual / 100m));
        }

        return _preco;
    }
}