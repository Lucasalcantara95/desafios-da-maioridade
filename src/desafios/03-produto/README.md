# 🧪 DESAFIO 3 — Produto (Encapsulamento Rigoroso)

## Enunciado
Crie uma classe chamada `Produto` com:
- Uma propriedade `Nome` (tipo `string`).
- Uma propriedade `Preco` (tipo `decimal`) com **validação rigorosa**: o preço **nunca** pode ser negativo. Se alguém tentar atribuir um valor negativo, o preço deve permanecer inalterado.
- Um método `AplicarDesconto(decimal percentual)` que reduz o preço pelo percentual informado (ex: `10m` = 10% de desconto). O percentual **não pode ser negativo nem maior que 100**. Se for inválido, o método não faz nada.
- Um método `GetPrecoComDesconto(decimal percentual)` que **retorna** o preço final após o desconto, **sem alterar** o preço original armazenado no objeto.

## Como entregar
1. Implemente a classe no arquivo `Produto.cs`.
2. **NÃO altere** o arquivo `Program.cs`.
3. Teste localmente com `dotnet run` e confirme que o output bate com o esperado.
4. Faça commit e push no seu fork.
5. Me mande o link do seu fork.

## Output Esperado
```text
Notebook - R$ 3000
Após tentar setar -500: R$ 3000
Após 10% de desconto: R$ 2700
Após tentar 150%: R$ 2700
Preco com 20% OFF (sem alterar original): R$ 2160
Preco original continua: R$ 2700
```

## O que será avaliado
- Uso correto de encapsulamento (propriedade com `get` e `set` customizado ou *backing field*).
- Validação no `set` do `Preco` (ignorar atribuição se `value < 0`).
- Diferença clara entre **modificar o estado** (`AplicarDesconto`) e **apenas calcular e retornar** (`GetPrecoComDesconto`).

Bora pra cima. 💪