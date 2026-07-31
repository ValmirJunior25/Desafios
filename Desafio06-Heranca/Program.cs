using System;

class Prgram
{
    static void Main()
    {
        // Placa ABC-1234 - Modelo: Civic
        //Placa XYZ-5678 - Modelo: Corolla
        //Placa MOT-0001 - Modelo: CB500
        //Placa MOT-0002 - Modelo: Biz


        List<Veiculo> veiculos = [];

        Carro v1 = new();
        v1.Modelo = "Civic";
        v1.Placa = "ABC-1234";
        v1.NumPortas = 4;

        Carro v2 = new() {Modelo = "Corolla", Placa = "XYZ-5678", NumPortas = 4};
        Moto v3 = new() {Modelo = "CB500", Placa = "MOT-0001", Cilindrada = 500};
        Moto v4 = new() {Modelo = "Biz", Placa = "MOT-0002", Cilindrada = 125};

        veiculos.Add(v1);
        veiculos.Add(v2);
        veiculos.Add(v3);
        veiculos.Add(v4);

        foreach(Veiculo veiculo in veiculos)
        {
            veiculo.ExibirDados();
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