using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        bool on = true;
        while (on)
        {
            Console.Clear();
            Console.Write("=== Conversor de Medidas === \n[ 1 ] Celsius / Fahrenheit \n[ 2 ] Quilômetros / Milhas \n[ 3 ] Quilogramas / Libras \n[ 4 ] Sair \n\n--> ");

            string escolhaMenu = Console.ReadLine() ?? "";

            switch (escolhaMenu)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("[ 1 ] Celsius --> Fahrenheit \n[ 2 ] Fahrenheit --> Celsius \n\n--> "); 
                        string escolha = Console.ReadLine() ?? "";
                        string escolhatxt;
                        
                        if (escolha == "1")
                        {
                            escolhatxt = "Fahrenheit";
                            Console.Write("Digite a teperatura em °C: ");
                            string numerotxt = Console.ReadLine();
                            double numeroConver = 0;

                            if (ValidarNumero(numerotxt))
                            {
                                double numero = double.Parse(numerotxt);
                                numeroConver = CelsiusFahrenheit(numero, escolhatxt);

                                Console.WriteLine($"{numero}°C = {numeroConver:F2}°F");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Numero invalido!");
                            }

                        }

                        else if (escolha == "2")
                        {
                            escolhatxt = "Celsius";
                            Console.Write("Digite a teperatura em °F: ");
                            string numerotxt = Console.ReadLine();
                            double numeroConver = 0;

                            if (ValidarNumero(numerotxt))
                            {
                                double numero = double.Parse(numerotxt);
                                numeroConver = CelsiusFahrenheit(numero, escolhatxt);

                                Console.WriteLine($"{numero}°F = {numeroConver:F2}°C");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Numero invalido!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida!");
                        }

                        Console.Write("Voltar para o menu [s/n]: ");
                        char saida = char.Parse((Console.ReadLine() ?? "n").ToLower().Trim());
                        if (saida == 's')
                        {
                            break;
                        }
                    }
                    break;


                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("[ 1 ] Quilômetros --> Milhas \n[ 2 ] Milhas --> Quilômetros \n\n--> "); 
                        string escolha = Console.ReadLine() ?? "";
                        string escolhatxt;
                        
                        if (escolha == "1")
                        {
                            escolhatxt = "Milhas";
                            Console.Write("Digite a distancia em Km: ");
                            string numerotxt = Console.ReadLine();
                            double numeroConver = 0;

                            if (ValidarNumero(numerotxt))
                            {
                                double numero = double.Parse(numerotxt);
                                numeroConver = QuilômetrosMilhas(numero, escolhatxt);

                                Console.WriteLine($"{numero} Km = {numeroConver:F2} milhas");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Numero invalido!");
                            }

                        }

                        else if (escolha == "2")
                        {
                            escolhatxt = "Quilômetros";
                            Console.Write("Digite a distancia em milhas: ");
                            string numerotxt = Console.ReadLine();
                            double numeroConver = 0;

                            if (ValidarNumero(numerotxt))
                            {
                                double numero = double.Parse(numerotxt);
                                numeroConver = QuilômetrosMilhas(numero, escolhatxt);

                                Console.WriteLine($"{numero} milhas = {numeroConver:F2} Km");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Numero invalido!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida!");
                        }


                        Console.Write("Voltar para o menu [s/n]: ");
                        char saida = char.Parse((Console.ReadLine() ?? "n").ToLower().Trim());
                        if (saida == 's')
                        {
                            break;
                        }
                    }               
                    break;


                case "3":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("[ 1 ] Quilogramas --> Libras \n[ 2 ] Libas --> Quilogramas \n\n--> "); 
                        string escolha = Console.ReadLine() ?? "";
                        switch (escolha)
                        {
                            case "1":
                                Console.WriteLine("Digite o pesoa em KG: ");
                                Console.ReadLine();
                                break;

                            
                            case "2":
                                Console.WriteLine("Digite o peso em libras: ");
                                Console.ReadLine();
                                break;
                        }

                        Console.Write("Voltar para o menu [s/n]: ");
                        char saida = char.Parse((Console.ReadLine() ?? "n").ToLower().Trim());
                        if (saida == 's')
                        {
                            break;
                        }
                    }               
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

    static bool ValidarNumero(string txt)
    {
        if (double.TryParse(txt, NumberStyles.Any, CultureInfo.InvariantCulture, out double numero))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static double CelsiusFahrenheit(double numero, string txt)
    {
        if (txt == "Fahrenheit")
        {
            double F = (numero * 1.8) + 32;
            return F;
        }
        else if(txt == "Celsius")
        {
            double C = (numero - 32) / 1.8;
            return C;
        }
        else
        {
            throw new ArgumentException("Unidade inválida");
        }

    }


    static double QuilômetrosMilhas(double numero, string txt)
    {
        if (txt == "Milhas")
        {
            double Ml = numero * 0.621371;
            return Ml;
        }
        else if(txt == "Quilômetros")
        {
            double Km = numero / 0.621371;
            return Km;
        }
        else
        {
            throw new ArgumentException("Unidade inválida");
        }

    }
}