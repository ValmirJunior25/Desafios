class Program
{
    static void Main()
    {
        LivroFisico l1 = new() {Titulo = "Clean Code", Autor = "Robert C. Martin", Tipo = "Físico", Quantidade = 3, Prateleira = "A3"};
        LivroFisico l2 = new() {Titulo = "O Programador Pragmático", Autor = "Andrew Hunt", Tipo = "Físico", Quantidade = 2, Prateleira = "A1"};
        LivroFisico l3 = new() {Titulo = "Domain-Driven Design", Autor = "Eric Evans", Tipo = "Físico", Quantidade = 1, Prateleira = "B2"};
        LivroFisico l4 = new() {Titulo = "Introdução a Algoritmos", Autor = "Thomas Cormen", Tipo = "Físico", Quantidade = 4, Prateleira = "C1"};
        LivroDigital l5 = new() {Titulo = "Refactoring", Autor = "Martin Fowler", Tipo = "Digita", Quantidade = 5, Tamanho = "8"};
        LivroDigital l6 = new() {Titulo = "Design Patterns", Autor = "Gang of Four", Tipo = "Digita", Quantidade = 5, Tamanho = "2"};
        LivroDigital l7 = new() {Titulo = "Effective C#", Autor = "Bill Wagner", Tipo = "Digita", Quantidade = 5, Tamanho = "3"};
        LivroFisico l8 = new() {Titulo = "O Homem e o Mar", Autor = "Ernest Hemingway", Tipo = "Físico", Quantidade = 0, Prateleira = "D4"};

        List<Livro> livrosAcervo = [l1, l2, l3, l4, l5, l6, l7, l8];
        
        bool on = true;
        while (on)
        {
            Console.Clear();
            Console.Write(
                "================ Biblioteca ================\n\n"+
                "1. Cadastrar livro\n"+
                "2. Emprestar livro\n"+
                "3. Devolver livro\n"+
                "4. Buscar livro por autor\n"+
                "6. Relatório (disponíveis / total no acervo)\n"+
                "7. Sair\n\n"+
                "-->"
            );

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write(
                            "======== Cadastro ========\n\n"+
                            "1. Cadastrar livro físico\n"+
                            "2. Cadastrar livro digital\n"+
                            "3. Voltar\n\n"+
                            "-->"
                        );
                        string cadastroMenu = Console.ReadLine();
                        if (cadastroMenu == "1")
                        {
                           Livro novoLivro = CadastrarLivro("Físico");
                            if (novoLivro != null)
                            {
                                livrosAcervo.Add(novoLivro);
                            }          
                        }
                        else if (cadastroMenu == "2")
                        {
                            Livro novoLivro = CadastrarLivro("Digital");
                            if (novoLivro != null)
                            {
                                livrosAcervo.Add(novoLivro);
                            }
                        }
                        else if (cadastroMenu == "3")
                        {
                            break;
                        }
                    }
                    break;


                case "2":
                    while (true)
                    {
                        Console.Clear();
                        string tipo;
                        Console.Write(
                            "===== Emprestar livro =====\n\n"+
                            "1. Emprestar livro físico\n"+
                            "2. Emprestar livro digital\n"+
                            "3. Voltar\n\n"+
                            "-->"
                        );
                        string emprestimoMenu = Console.ReadLine();
                            if (emprestimoMenu == "1")
                            {
                                tipo = "Físico";
                            }
                            else if (emprestimoMenu == "2")
                            {
                                tipo = "Digital";
                            }
                            else if (emprestimoMenu == "3")
                            {
                                break;
                            }

                            
                        }
                    break;

                case "3":
                    break;


                case "4":
                    break;


                case "5":
                    break;


                case "6":
                    CabecalhoTitulo();
                    foreach(Livro l in livrosAcervo)
                    {
                        l.ExibirLivro();
                    }
                    break;


                case "7":
                    Console.Write("Confirmar saida [s/n]: ");
                    string saidaMenu = (Console.ReadLine() ?? "n").ToLower().Trim();
                    if (saidaMenu == "s")
                    {
                        on = false;
                    }

                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }
    }

    static Livro CadastrarLivro(string tipo)
    {
        try
        {
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine().Trim();
            Console.Write("Autor: ");
            string autor = Console.ReadLine().Trim();
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine().Trim());

            if (tipo == "Físico")
            {
                Console.Write("Prateleira: ");
                string prateleira = Console.ReadLine().Trim();
                LivroFisico novoLivro = new() {Titulo = titulo, Autor = autor, Tipo = "Físico", Quantidade = quantidade, Prateleira = prateleira};

                Console.WriteLine("\n======================================= Cadastrar o livro? =======================================");
                CabecalhoTitulo();
                novoLivro.ExibirLivro();
                Console.Write("Confirme [s/n]: ");
                string conf = Console.ReadLine();
                if (conf == "s")
                {
                    return novoLivro;
                }
            }
            else if (tipo == "Digital")
            {
                Console.Write("Tamanho: ");
                string tamanho = Console.ReadLine().Trim();
                LivroDigital novoLivro = new() {Titulo = titulo, Autor = autor, Tipo = "Digital", Quantidade = quantidade, Tamanho = tamanho};

                Console.WriteLine("\n======================================= Cadastrar o livro? =======================================");
                CabecalhoTitulo();
                novoLivro.ExibirLivro();
                Console.Write("Confirme [s/n]: ");
                string conf = Console.ReadLine();
                if (conf == "s")
                {
                    return novoLivro;
                }
            }          
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERRO! {ex.GetType().Name}");
            Console.ReadLine();
        }
        return null;
    }

    static void CabecalhoTitulo()
    {
        Console.WriteLine($"{"=========== Titulo ===========", -30} | {"====== Autor ======", -20} | {"== Tipo ==", -10} | {"Quantidade", -10} | {"==== Extra ====", -10}");
    }

    
}


class Livro
{
    public string Titulo;
    public string Autor;
    public string Tipo;
    private int _quantidade;

    public int Quantidade
    {
        get{return _quantidade; }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Quantidade de livro insuficiente.");
                Console.ReadLine();
            }
            else
            {
                _quantidade = value;
            }
        }
    }

    public virtual void ExibirLivro()
    {
        Console.WriteLine($"{Titulo, -30} | {Autor, -20} | {Tipo, -10} | {Quantidade, -10}");
    }


}

class LivroFisico : Livro
{
    public string Prateleira;

    public override void ExibirLivro()
    {
        Console.WriteLine($"{Titulo, -30} | {Autor, -20} | {Tipo, -10} | {Quantidade, -10} | Prateleira: {Prateleira, -3}");
    }

}

class LivroDigital : Livro
{
    public string Tamanho;

    public override void ExibirLivro()
    {
        Console.WriteLine($"{Titulo, -30} | {Autor, -20} | {Tipo, -10} | {Quantidade, -10} | Tamanho: {Tamanho, -3}MB");
    }

}