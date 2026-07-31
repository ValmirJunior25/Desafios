
class Program
{
    static void Main()
    {
        // Placa ABC-1234 - Modelo: Civic
        // Placa XYZ-5678 - Modelo: Corolla
        // Placa MOT-0001 - Modelo: CB500
        // Placa MOT-0002 - Modelo: Biz
        // Placa MOT-0003 - Modelo: Pop

        Carro v1 = new() {Placa = "ABC-1234", Modelo = "Civic", NumPortas = 4};
        Carro v2 = new() {Modelo = "Corolla", Placa = "XYZ-5678", NumPortas = 4};
        Moto v3 = new() {Modelo = "CB500", Placa = "MOT-0001", Cilindrada = 500};
        Moto v4 = new() {Modelo = "Biz", Placa = "MOT-0002", Cilindrada = 125};
        Moto v5 = new() {Modelo = "Pop", Placa = "MOT-0003", Cilindrada = 110};

        List<Veiculo> veiculos = [v1, v2, v3, v4, v5];

        while (true)
        {   
            int posicao;
            try
            {
                Console.WriteLine("=== Consultar de veiculos ===\n\nProdutos disponíveis: 5 (posições de 1 a 5)");
                Console.Write("Digite a posição: ");
                posicao = int.Parse(Console.ReadLine() ?? "");

                Console.Write("Veiculo: ");
                veiculos[posicao - 1].ExibirDados();
            }
            catch (FormatException)
            {
                Console.WriteLine($"ERRO: isso não é um número válido.");
                
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"ERRO: essa posição não existe no array.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO! {ex.GetType().Name}");
            }

            Console.ReadLine();
        }
    }
}


class Veiculo
{
    public string Placa = "";
    public string Modelo = "";


    public virtual void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa} - Modelo: {Modelo}");
    }
}


class Carro : Veiculo
{
    public int NumPortas;

    public override void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa} - Modelo: {Modelo} - Portas: {NumPortas}");
    }
}


class Moto : Veiculo
{
    public int Cilindrada;

    public override void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa} - Modelo: {Modelo} - Cilindrada: {Cilindrada}");
    }
}