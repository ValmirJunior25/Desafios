
class Program
{
    static void Main()
    {
        List<int> numeros = [10, -3, 7, -22, 5, 18, -8, 4];

        var positivos = numeros.Where(n => n >= 0);
        var pares = numeros.Where(n => n % 2 == 0);
        var ordenados = numeros.OrderByDescending(n => n);
        var soma = numeros.Sum();
        var madia = numeros.Average();

        Console.Write($"Números: "); 
        foreach(int numero in numeros)
        {
            Console.Write($"{numero}, ");
        }
        Console.WriteLine("\n");

        Console.Write($"Positivos: "); 
        foreach(int positivo in positivos)
        {
            Console.Write($"{positivo}, ");
        }
        Console.WriteLine("");

        Console.Write($"Pares: "); 
        foreach(int par in pares)
        {
            Console.Write($"{par}, ");
        }
        Console.WriteLine("");

        Console.Write($"Ordenado : "); 
        foreach(int ordenado in ordenados)
        {
            Console.Write($"{ordenado}, ");
        }
        Console.WriteLine("");


        Console.WriteLine($"Soma: {soma} \nMédia: {madia}");

    }
}