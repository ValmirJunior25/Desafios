using System;
using System.Reflection.PortableExecutable;

class Desafio004
{
    public void Desafio4()
    {
        string clasificacao = "", continuar;
        decimal altura, imc, peso;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Cauculo do IMC");
            Console.Write("Seu peso: ");
            peso = decimal.Parse(Console.ReadLine() ?? "0");
            Console.Write("Sua altura: ");
            altura = decimal.Parse(Console.ReadLine() ?? "0");

            imc = peso / (altura * altura);
            
            if (imc < 18.5m)
            {
                clasificacao = "Baixo peso";
            }
            else if (imc >= 18.5m && imc < 25m)
            {
                clasificacao = "Peso normal";
            }
            else if (imc >= 25m && imc < 30m)
            {
                clasificacao = "Excesso de peso";
            }
            else if (imc >= 30)
            {
                clasificacao = "Obesidade";
            }

            Console.WriteLine($"Seu IMC: {imc}");
            Console.WriteLine($"Você está classificado como: {clasificacao}");

            Console.Write($"Deseja caucular novamente (s/n)?");
            continuar = Console.ReadLine() ?? "n";

            if (continuar == "n")
            {
                break;
            }
        }
    }
}