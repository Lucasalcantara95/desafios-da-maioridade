# 🎯 Mentoria C# — Desafios Semanais

Repositório oficial dos desafios de Orientação a Objetos em C#.

## 📏 Regras do Jogo

1. **Prazo:** 7 dias corridos por desafio.
2. **Fluxo de trabalho:**
   - Faça **fork** deste repositório para a sua conta.
   - Clone o **seu fork** na sua máquina.
   - Resolva o desafio, faça commit e push no seu fork.
   - Me mande o link do seu fork para eu avaliar.
3. **O que eu NÃO aceito:**
   - Alterar o `Program.cs` (código de teste).
   - Código que não compila ou output diferente do esperado.
4. **Progressão:** só libero o próximo desafio quando o anterior estiver **aprovado**.

## 🔄 Como sincronizar seu fork quando eu adicionar novos desafios

Quando eu adicionar um novo desafio neste repositório, você precisa atualizar o seu fork. Tem dois jeitos:

### Jeito fácil (pelo site do GitHub)
1. Entre no **seu fork** no GitHub.
2. Clique no botão **"Sync fork"** → **"Update branch"**.
3. Na sua máquina, rode: `git pull origin main`

### Jeito via linha de comando (recomendado)
Configure uma vez só o repositório original como upstream:
```bash
git remote add upstream https://github.com/SEU-USUARIO/mentoria-csharp.git
```

Sempre que eu adicionar um desafio novo, rode:
```bash
git fetch upstream
git checkout main
git merge upstream/main
git push origin main
```

## 📂 Estrutura

Cada desafio vive em `desafios/XX-nome-do-desafio/`:
- `README.md` → enunciado
- `Program.cs` → código de teste (não mexe!)
- `NomeDaClasse.cs` → o que você cria

## 🚀 Como rodar

```bash
cd desafios/01-conversor-temperatura
dotnet run
```

---

Bora pra cima. 💪
