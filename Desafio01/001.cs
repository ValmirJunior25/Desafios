using System;
class Desafio001
{
    static void Main()
    {

        string produto = "Caneta Azul";
        decimal preco = 2.5m;
        int estoque = 150;
        bool disponivel = true;

        Console.WriteLine($"Produto: {produto}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Quantidade em estoque: {estoque}");
        Console.WriteLine($"Disponível para venda: {disponivel}");
    }
}