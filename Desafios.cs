using System;

class Desafio
{
    static void Main()
    {
        Console.Clear();

        int total = 0, positivos = 0;

        Console.WriteLine("Digite 5 números inteiros.");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o número {i}: ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            total += num;

            if (num > 0)
            {
                positivos++;
            }
        }

        Console.WriteLine($"Soma total: {total}");
        Console.WriteLine($"Média: {total / 5m}");
        Console.WriteLine($"Números positivos: {positivos}");

    }
}