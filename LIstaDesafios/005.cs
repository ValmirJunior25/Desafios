using System;

class Desafio005
{
    public void Desafio5()
    {   
        string continuar, vip, vipconf;
        decimal compra, desconto = 0;
        int desc = 0;
        
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Cálculo de desconto!!!");

            Console.Write("Valor da compra: ");
            compra = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Cliente VIP (s/n)? ");
            vip = Console.ReadLine() ?? "n";

            if (vip == "s")
            {
                vipconf = "Sim";
            }
            else
            {
                vipconf = "Não";
            }

            if (compra > 1000)
            {
                desconto = 0.15m;
                desc = 15;
            }
            else if (compra >= 500 && compra <= 1000)
            {
                desconto = 0.1m;
                desc = 10;
            }
            else if (compra < 500 && compra >= 200)
            {
                desconto = 0.05m;
                desc = 5;
            }
            else if (compra < 200)
            {
                desconto = 0;
                desc = 0;
            }

            if (vip == "s")
            {
                desconto += 0.05m;
                desc += 5;
            }

            Console.Clear();
            Console.WriteLine($"Valor da compra: {compra}");
            Console.WriteLine($"Cliente VIP? {vipconf}");
            Console.WriteLine($"Desconto aplicado: {desc}%");
            Console.WriteLine($"Valor do desconto: R${compra * desconto}");
            Console.WriteLine($"Valor final a pagar: R${compra - (compra * desconto)}");

            Console.Write($"Deseja fazer novamente (s/n)?");
            continuar = Console.ReadLine() ?? "n";

            if (continuar == "n")
            {
                break;
            }
        }
    }
}