using System;

class Desafio002
{
    public void Desafio2()
    {
        string nome = "Valmir Júnior";
        int idade = 25;
        decimal salario = 5000;
        string cargo = "Analista de Sistemas";
        bool gerente = false;
        decimal bonus = salario * 0.1m;

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"É gerente? {gerente}");
        Console.WriteLine($"Bônus (10%): {bonus}");
        
    }
}