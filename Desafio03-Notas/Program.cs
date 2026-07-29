using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main()
    {
        List <double> notas = [];
        while (true)
        {
            Console.Clear();
            Console.Write("Quantas notas deseja inserir? ");
            if (int.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out int numDeNotas))
            {
                for (int i = 1; i <= numDeNotas; i++)
                {
                    while (true)
                    {
                        Console.Write($"{i}° Nota: ");
                        if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double nota))
                        {
                            if (nota >= 0 && nota <= 10)
                            {
                            notas.Add(nota);
                            break;
                            }
                            else
                            {
                                Console.WriteLine("\nValor invalido! Notas maiores que 10 e menores que 0 não são permitidas!\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nValor invalido!\n");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Numero invalido! ");
            }


            double media = CalcularMedia(notas);
            double maiorNota = EncotrarMaior(notas);
            double menorNota = EncontrarMenor(notas);

            Console.WriteLine($"\n\nMedia: {media}  \nMaior nota: {maiorNota}  \nMenor nota: {menorNota}\n\n");



            Console.Write("Desaja sair [s/n]? ");
            string saidaMenu = (Console.ReadLine() ?? "n").ToLower().Trim();
            if (saidaMenu == "s")
            {
                break;
            }
        }
    }


    static double CalcularMedia(List<double> notas)
    {
        double somaTotal = 0;
        foreach (double nota in notas)
        {
            somaTotal += nota;
        }
        return somaTotal / notas.LongCount();
    }


    static double EncotrarMaior(List<double> notas)
    {
        double maior = 0;
        foreach (double nota in notas)
        {
            if (nota > maior)
            {
                maior = nota;
            }
        }
        return maior;
    }


    static double EncontrarMenor(List<double> notas)
    {
        double menor = 10;
        foreach (double nota in notas)
        {
            if (nota < menor)
            {
                menor = nota;
            }
        }
        return menor;
    }
}