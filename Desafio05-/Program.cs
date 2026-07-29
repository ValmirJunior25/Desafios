using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        List<Produto> produtos = new();

        Produto p1 = new Produto();
        p1.Nome = "Notebook";
        p1.setPreco(3500);
        p1.Quantidade = 10;

        Produto p2 = new();
        p2.Nome = "Celular";
        p2.Preco = 2300;
        p2.Quantidade = 20;

        Produto p3 = new();
        p3.Nome = "Fone";
        p3.Preco = 500;
        p3.Quantidade = 30;

        Produto p4 = new();
        p4.Nome = "Mouse";
        p4.Preco = 114;
        p4.Quantidade = 25;

        produtos.Add(p1);
        produtos.Add(p2);
        produtos.Add(p3);
        produtos.Add(p4);

        Console.WriteLine("=== Antes do desconto ===");
        decimal semDesconto = 0;
        foreach (Produto produto in produtos)
        {
            produto.ExibirDados();
            semDesconto += produto.getPreco() * produto.Quantidade;
        }
        Console.WriteLine($"\nValor total sem desconto: R$ {semDesconto:F2}\n\n");

        Console.WriteLine("=== Depois do desconto (10%) ===");
        decimal comDesconto = 0;
        foreach (Produto produto in produtos)
        {
            produto.AplicarDesconto(10);
            produto.ExibirDados();
            comDesconto += produto.getPreco() * produto.Quantidade;
        }
        Console.WriteLine($"\nValor total com desconto: R$ {comDesconto:F2}");
    }
}


class Produto
{
    public string Nome;
    private decimal Preco;
    private int Quantidade;


    public decimal getPreco()
    {
        return Preco;
    }
    public decimal setPreco(decimal valor)
    {
        if (valor < Preco)
        {
            Console.WriteLine($"Preço inválido! Manter valor anterior: R$ {Preco}");
            return Preco;
        }
        else
        {
            Preco = valor;
            Console.WriteLine($"Preço definido: R$ {Preco}");
            return Preco;
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome} - R$ {Preco:F2} - Estoque: {Quantidade}");
    }

    public void AplicarDesconto(decimal percentual)
    {
        Preco = Preco - (Preco * (percentual / 100));
    }
}