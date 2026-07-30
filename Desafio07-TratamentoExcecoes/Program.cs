class Program
{
    static void Main()
    {
        int numerador;
        int denominador;
        double res;

        while (true)
        {
            try
            {
                Console.Write("Digite o Numerador: ");
                numerador = int.Parse(Console.ReadLine());
                Console.Write("Digite o Denominador: ");
                denominador = int.Parse(Console.ReadLine());

                res = (double)numerador/denominador;
                Console.WriteLine($"{numerador} / {denominador} = {res}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"ERRO: numero não é válido.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"ERRO: não é possível dividir por zero.");
            }
        }
    }
}