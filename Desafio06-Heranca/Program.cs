using System;

class Prgram
{
    static void Main()
    {
        // Placa ABC-1234 - Modelo: Civic
        //Placa XYZ-5678 - Modelo: Corolla
        //Placa MOT-0001 - Modelo: CB500
        //Placa MOT-0002 - Modelo: Biz


        List<Veicolo> veicolos = [];

        Carro v1 = new();
        v1.Modelo = "Civic";
        v1.Placa = "ABC-1234";
        v1.NumPortas = 4;

        Carro v2 = new() {Modelo = "Corolla", Placa = "XYZ-5678", NumPortas = 4};
        Moto v3 = new() {Modelo = "CB500", Placa = "MOT-0001", Cilindrada = 500};
        Moto v4 = new() {Modelo = "Biz", Placa = "MOT-0002", Cilindrada = 125};

        veicolos.Add(v1);
        veicolos.Add(v2);
        veicolos.Add(v3);
        veicolos.Add(v4);

        foreach(Veicolo veicolo in veicolos)
        {
            veicolo.ExibirDados();
        }
    }

}


class Veicolo
{
    public string Placa = "";
    public string Modelo = "";


    public virtual void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa} - Modelo: {Modelo}");
    }
}


class Carro : Veicolo
{
    public int NumPortas;

    public override void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa} - Modelo: {Modelo} - Portas: {NumPortas}");
    }
}


class Moto : Veicolo
{
    public int Cilindrada;

    public override void ExibirDados()
    {
        Console.WriteLine($"Placa: {Placa} - Modelo: {Modelo} - Cilindrada: {Cilindrada}");
    }
}