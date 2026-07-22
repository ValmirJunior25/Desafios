using System.Linq;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo cultura = new CultureInfo("pt-BR");
        bool on = true;

        Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>
        {
            {"Ana Silva",  [7.5, 8.0, 6.5]},
            {"Carlos Mendes", [4.0, 3.5, 5.0]},
            {"Fernanda Lima", [9.0, 9.5, 8.5]},
            {"Roberto Costa", [5.0, 6.0, 5.5]},
            {"Juliana Souza", [3.0, 2.5, 4.0]},
            {"Marcos Oliveira", [8.0, 7.5, 9.0]},
            {"Patrícia Rocha", [6.0, 5.5, 6.5]},
            {"Diego Alves", [4.5, 5.0, 3.5]},
            {"Camila Ferreira", [7.0, 8.5, 7.5]},
            {"Lucas Pereira", [2.0, 3.0, 2.5]}
        };
        while (on)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Notas === \n1. Adicionar aluno \n2. Ver todos os alunos \n3. Buscar aluno \n4. Sair");
            Console.Write("\n-> ");
            string escolhaMenu = (Console.ReadLine() ?? "").Trim();


            switch (escolhaMenu)
            {
                case "1":
                    while (true)
                    {
                        bool verificador = true;
                        List<double> notas = [];

                        Console.Clear();
                        Console.WriteLine("=== Adicionar aluno ===");

                        Console.Write("Nome do aluno: ");
                        string nomeAluno = Console.ReadLine() ?? "";
                        Console.Write("1° nota: ");
                        string nota1tx = Console.ReadLine() ?? "";
                        Console.Write("2° nota: ");
                        string nota2tx = Console.ReadLine() ?? "";
                        Console.Write("3° nota: ");
                        string nota3tx = Console.ReadLine() ?? "";

                        if (nomeAluno == "")
                        {
                            verificador = false;
                        }
                        if(!double.TryParse(nota1tx, NumberStyles.Any, cultura, out double nota1))
                        {
                            verificador = false;
                        }
                        if(!double.TryParse(nota2tx, NumberStyles.Any, cultura, out double nota2))
                        {
                            verificador = false;
                        }
                        if(!double.TryParse(nota3tx, NumberStyles.Any, cultura, out double nota3))
                        {
                            verificador = false;
                        }
   
                        if (verificador)
                        {
                            Console.WriteLine($"\nAdicionar: \nNome: {nomeAluno} \nNotas: {nota1}, {nota2}, {nota3}");
                            Console.Write("\nConfirme [s/n]: ");
                            string confirma1 = (Console.ReadLine() ?? "n").ToLower().Trim();
                            if (confirma1 == "s")
                            {
                                notas.Add(nota1);
                                notas.Add(nota2);
                                notas.Add(nota3);

                                alunos.Add(nomeAluno, notas);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dados invalidos!");
                        }
                        
                        Console.Write("Voltar para o menu [s/n]? ");
                        string saida1 = (Console.ReadLine() ?? "n").ToLower().Trim();
                        if (saida1 == "s")
                        {
                            break;
                        }
                    }
                    break;


                case "2":
                    Console.Clear();
                    Console.WriteLine($"=== Alunos ===");

                    foreach (KeyValuePair<string, List<double>> aluno in alunos)
                    {
                        Console.Write($"{aluno.Key} - Notas: ");
                        foreach (double nota in aluno.Value)
                        {
                            Console.Write($"({nota}) ");
                        }
                        Console.Write($"- Média: {aluno.Value.Average():F1} - ");
                        if (aluno.Value.Average() < 5)
                        {
                            Console.Write($"Reprovado");
                        }
                        else if (aluno.Value.Average() >= 5 && aluno.Value.Average() < 7)
                        {
                            Console.Write($"Recuperação");
                        }
                        else if (aluno.Value.Average() >= 7)
                        {
                            Console.Write($"Aprovado");
                        }
                        Console.WriteLine("");
                    }

                    Console.Write("Pressione qualquer tecla para voltar ao menu.");
                    string saida2 = Console.ReadLine() ?? "";
                    break;



                case "3":
                    while (true)
                    {
                       Console.Clear();
                        Console.WriteLine($"=== Buscar alunos ===");
                        Console.Write("Nome do aluno: ");
                        string buscador3 = (Console.ReadLine() ?? "").Trim();
                        foreach(KeyValuePair<string, List<double>> aluno in alunos)
                        {
                            if (aluno.Key.Contains(buscador3, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write($"{aluno.Key} - Notas: ");
                                foreach (double nota in aluno.Value)
                                {
                                    Console.Write($"({nota}) ");
                                }
                                Console.Write($"- Média: {aluno.Value.Average():F1} - ");
                                if (aluno.Value.Average() < 5)
                                {
                                    Console.Write($"Reprovado");
                                }
                                else if (aluno.Value.Average() >= 5 && aluno.Value.Average() < 7)
                                {
                                    Console.Write($"Recuperação");
                                }
                                else if (aluno.Value.Average() >= 7)
                                {
                                    Console.Write($"Aprovado");
                                }
                                Console.WriteLine("");
                            }
                        } 
                        Console.Write("Voltar para o menu [s/n]? ");
                        string saida3 = (Console.ReadLine() ?? "n").ToLower().Trim();
                        if (saida3 == "s")
                        {
                            break;
                        }
                    }
                    break;


                case "4":
                    Console.Write("Confirmar saida [s/n]: ");
                    char saidaMenu = char.Parse((Console.ReadLine() ?? "n").ToLower().Trim());
                    if (saidaMenu == 's')
                    {
                        on = false;
                    }
                    break;


                default:
                    break;
                    
            }
        }
    }
}