using System;

class Program
{
    static void Main()
    {
        bool on = true;
        while (on)
        {
            Console.Clear();
            Console.Write("=== Conversor de Medidas === \n1. Celsius → Fahrenheit \n2. Quilômetros → Milhas \n3. Quilogramas → Libras \n4. Sair");

            string escolhaMenu = Console.ReadLine() ?? "";

            switch (escolhaMenu)
            {
                case "1":

                    break;


                case "2":
                
                    break;


                case "3":
                
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