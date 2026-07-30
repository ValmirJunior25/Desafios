using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Produto p1 = new Produto();
        p1.Nome = "Notebook";
        p1.Preco = 3500;
        p1.Quantidade = 10;

        Produto p2 = new();
        p2.Nome = "Celular";
        p2.Preco = 2300;
        p2.Quantidade = 20;

        Produto p3 = new();
        p3.Nome = "Fone";
        p3.Preco= 500;
        p3.Quantidade = 30;

        Produto p4 = new();
        p4.Nome = "Mouse";
        p4.Preco = 114;
        p4.Quantidade = 25;

        Console.WriteLine("\n\nTentando definir preço e quantidade em -100...");
        p1.Preco = -100;
        p1.Quantidade = -100;
        p1.ExibirDados();

        Console.WriteLine("\n\nTentando definir preço e quantidade em 100...");
        p1.Preco = 100;
        p1.Quantidade = 100;
        p1.ExibirDados();

    }
}


class Produto
{
    public string Nome = "";
    private decimal _preco;
    private int _quantidade;


    public decimal Preco
    {
        get { return _preco; }

        set
        {
            if (value < 0)
            {
                Console.WriteLine($"Preço inválido! Manter valor anterior: R$ {_preco}");
            }
            else
            {
                _preco = value;
            } 
        }
    }


    public int Quantidade
    {
        get
        { return _quantidade; }

        set
        {
            if (value < 0)
            {
                Console.WriteLine($"Quantidade inválida! Manter quantidade anterior: {_quantidade}");
            }
            else
            {
                _quantidade = value;
            } 
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