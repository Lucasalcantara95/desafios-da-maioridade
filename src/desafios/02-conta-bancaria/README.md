# 🧪 DESAFIO 2 — Conta Bancaria (Estado e Validação)

## Enunciado
Crie uma classe chamada `ContaBancaria` com as seguintes características:
- Uma propriedade `Titular` do tipo `string`.
- Uma propriedade `Saldo` do tipo `decimal`.
- Um método `Depositar(decimal valor)` que adiciona o valor ao saldo.
- Um método `Sacar(decimal valor)` que subtrai o valor do saldo **APENAS se houver saldo suficiente**. 
  - Se houver saldo, o método deve subtrair o valor e retornar `true`.
  - Se não houver saldo suficiente, o método **não deve alterar o saldo** e deve retornar `false`.

## Como entregar
1. Implemente a classe no arquivo `ContaBancaria.cs`.
2. **NÃO altere** o arquivo `Program.cs`.
3. Teste localmente com `dotnet run` e confirme que o output bate com o esperado.
4. Faça commit e push no seu fork.
5. Me mande o link do seu fork.

## Output Esperado
```text
Titular: Carlos
Saldo inicial: 1000
Saque de 300: True | Saldo: 700
Saque de 2000: False | Saldo: 700
Após depósito de 500: 1200
```

## O que será avaliado
- Você entendeu que `Saldo` é um **estado** do objeto que persiste entre chamadas de método?
- Você implementou a validação `if` corretamente antes de subtrair o valor?
- O método `Sacar` retorna `bool` conforme solicitado?

Bora pra cima. 💪