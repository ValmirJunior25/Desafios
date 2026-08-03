

class Program
{
    static void Main()
    {
        Funcionario f1 = new() { Nome = "João", Salario = 2000, Departamento = "TI" };
        Funcionario f2 = new() { Nome = "Maria", Salario = 2500, Departamento = "RH" };
        Funcionario f3 = new() { Nome = "Carlos", Salario = 2200, Departamento = "TI" };
        Funcionario f4 = new() { Nome = "Ana", Salario = 2700, Departamento = "Financeiro" };
        Funcionario f5 = new() { Nome = "Pedro", Salario = 2100, Departamento = "TI" };
        Funcionario f6 = new() { Nome = "Fernanda", Salario = 2600, Departamento = "RH" };
        Funcionario f7 = new() { Nome = "Lucas", Salario = 2300, Departamento = "Financeiro" };
        Funcionario f8 = new() { Nome = "Beatriz", Salario = 2400, Departamento = "Marketing" };

        Gerente g1 = new() { Nome = "Roberto", Salario = 5000, Departamento = "TI", Bonus = 1500 };
        Gerente g2 = new() { Nome = "Juliana", Salario = 5500, Departamento = "RH", Bonus = 1800 };

        List<Funcionario> funcionarios= [f1, f2, f3, f4, f5, f6, f7, f8, g1, g2];
        foreach(Funcionario f in funcionarios)
        {
            f.ExibirDados();
        }

        var departamentoTI = funcionarios
            .Where(f => f.Departamento == "TI")
            .OrderByDescending(f => f.Salario)
            .Select(f => f.Nome);

        Console.Write("\n\nDepartamento de TI: ");
        foreach (string f in departamentoTI)
        {
            Console.Write($"{f}, ");
        }

        bool verificaSalario = funcionarios.Any(f => f.Salario > 10000);
        Console.Write($"\nExiste algum funcionário com salário acima de R$10.000? ");
        if (verificaSalario)
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Não");
        }

        var quantosTI = funcionarios.Count(f => f.Departamento == "TI");
        Console.WriteLine($"Funcionários existem no departamento TI: {quantosTI}");

        decimal folhaSalarial = funcionarios.Sum(f => f.SalarioBonus());
        Console.WriteLine($"Soma total da folha salarial: {folhaSalarial}");

    }
}


class Funcionario
{
    public string Nome = "";
    public decimal Salario;
    public string Departamento = "";

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome} - Salario: {Salario} - Departamento: {Departamento}");
    }

    public virtual decimal SalarioBonus()
    {
        return Salario;
    }

}


class Gerente : Funcionario
{
    public decimal Bonus;

    public override void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome} - Salario: {Salario} - Departamento: {Departamento} - Bônus: {Bonus}");
    }

    public override decimal SalarioBonus()
    {
        return base.SalarioBonus() + Bonus;
    }
    
}