# 🧪 DESAFIO 4 — Carrinho de Compras (Composição de Objetos)

## Enunciado
Crie **duas** classes que trabalham juntas:

**1. Classe `Item`:**
- Propriedade `Nome` (string)
- Propriedade `PrecoUnitario` (decimal)
- Propriedade `Quantidade` (int)
- Método `GetSubtotal()` que retorna `PrecoUnitario * Quantidade`

**2. Classe `CarrinhoDeCompras`:**
- Deve possuir uma lista interna de `Item` (use `List<Item>`).
- Método `AdicionarItem(Item item)` que adiciona um item à lista.
- Método `GetTotal()` que retorna a soma dos subtotais de **todos** os itens do carrinho.
- Método `GetQuantidadeTotalDeProdutos()` que retorna a soma das quantidades de todos os itens.

## Como entregar
1. Implemente as classes nos arquivos `Item.cs` e `CarrinhoDeCompras.cs`.
2. **NÃO altere** o arquivo `Program.cs`.
3. Teste localmente com `dotnet run` e confirme que o output bate com o esperado.
4. Faça commit e push no seu fork.
5. Me mande o link do seu fork.

## Output Esperado
```text
Subtotal Mouse: R$ 160
Subtotal Teclado: R$ 150
Subtotal Monitor: R$ 1200
Quantidade total de produtos: 4
Total do carrinho: R$ 1510
```

## O que será avaliado
- Entendimento de **Composição** (um objeto contendo uma lista de outros objetos).
- Uso correto de `List<T>` e iteração (`foreach` ou `LINQ`) para somar valores.
- Separação de responsabilidades: o `Item` calcula o próprio subtotal, o `Carrinho` apenas delega e soma.

Bora pra cima. 💪