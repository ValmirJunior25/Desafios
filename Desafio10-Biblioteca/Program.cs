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

        List<Livro> LivrosAcervo = [l1, l2, l3, l4, l5, l6, l7, l8];
        
        bool on = true;
        while (on)
        {
            Console.Clear();
            Console.Write(
                "=== Biblioteca ===\n\n"+
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
                    
                    break;


                case "2":
                    break;


                case "3":
                    break;


                case "4":
                    break;


                case "5":
                    break;


                case "6":
                    Console.WriteLine($"{"=========== Titulo ===========", -30} | {"====== Autor ======", -20} | {"== Tipo ==", -10} | {"Quantidade", -10} |  {"== Extra ==", -3}");
                    foreach(Livro l in LivrosAcervo)
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

    public virtual void Cadastrar(string titulo, string autor, string tipo, int quantidade)
    {
        
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