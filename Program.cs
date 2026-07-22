using System;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contatos = new()
        {
            {"João", "(85) 99999-0000"},
            {"Maria", "(11) 98888-1111"}
        };
        bool on = true;

        while (on)
        {
            Console.Clear();
            Console.WriteLine("=== Agenda === \n1. Ver contatos \n2. Adicionar contato \n3. Buscar contato \n4. Remover contato \n5. Sair");

            Console.Write("-> ");
            int menu = int.Parse(Console.ReadLine() ?? "0");
            switch (menu)
            {
                case 1:
                    while (true)
                    {
                        Console.Clear();
                        int cont = 1;
                        Console.WriteLine("=== Contatos ===");
                        foreach(KeyValuePair<string, string> contato in contatos)
                        {
                            Console.WriteLine($"{cont}. {contato.Key} - {contato.Value}");
                            cont ++;
                        }
                        Console.Write("Voltar para menu [s/n]? ");
                        string sair3 = Console.ReadLine() ?? "";
                        if (sair3 == "s")
                        {
                            break;
                        }
                    }
                    break;

                case 2:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Adicionar contato ===");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine() ?? "";
                        Console.Write("Numero: ");
                        string numero = Console.ReadLine() ?? "";
                        contatos.Add( nome, numero);
                        Console.Write("Voltar para menu [s/n]? ");
                        string sair3 = Console.ReadLine() ?? "";
                        if (sair3 == "s")
                        {
                            break;
                        }
                    }
                    
                    break;

                case 3:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Buscar contato ===");
                        Console.Write("Nome: ");
                        string buscador3 = Console.ReadLine() ?? "";
                        foreach(var contato in contatos)
                        {
                            if (contato.Key.Contains(buscador3, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"{contato.Key}: {contato.Value}");
                            }
                        }
                        Console.Write("Voltar para menu [s/n]? ");
                        string sair3 = Console.ReadLine() ?? "";
                        if (sair3 == "s")
                        {
                            break;
                        }
                    }
                    break;

                case 4:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Remover contato ===");
                        Console.Write("Nome: ");
                        string buscador4 = Console.ReadLine() ?? "";
                        foreach(var contato in contatos)
                        {
                            if (contato.Key.Contains(buscador4, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write($"Deseja remover esse contato {contato.Key}: {contato.Value} [s/n]? ");
                                string escolha4 = Console.ReadLine() ?? "";
                                if (escolha4 == "s")
                                {
                                contatos.Remove(contato.Key); 
                                }
                                
                            }
                        }
                        Console.Write("Voltar para menu [s/n]? ");
                        string sair4 = Console.ReadLine() ?? "";
                        if (sair4 == "s")
                        {
                            break;
                        }

                    }
                    break; 

                case 5:
                    Console.WriteLine("Sair");
                    Console.Write("Confirmar saida [s/n]? ");
                    string sairAgenda = Console.ReadLine() ?? "";
                    if (sairAgenda == "s")
                    {
                        on = false;
                    }
                    break;
                
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}