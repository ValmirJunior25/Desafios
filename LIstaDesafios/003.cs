using System;

class Desafio003
{
    public void Desafio3()
    {
        int idade;
        string ingresso;
        bool  maiorIdade = false, podeEntrar = false;

        Console.Write("Sua idade: ");
        idade = int.Parse(Console.ReadLine()?? "0");

        Console.Write("Você tem Ingresso (s/n)? ");
        ingresso = Console.ReadLine()?? "n";

        if (idade >= 18)
        {
            maiorIdade = true;
        }
        if (maiorIdade && ingresso == "s")
        {
            podeEntrar = true;
        }
        if (ingresso == "s")
        {
            ingresso = "Sim";
        }
        else
        {
            ingresso = "Não";
        }
        
        Console.WriteLine($"Idada: {idade}");
        Console.WriteLine($"Tem ingresso? {ingresso}");
        Console.WriteLine($"Maior de idade? {maiorIdade}");
        Console.WriteLine($"Pode entrar no envento? {podeEntrar}");
        
    }
}