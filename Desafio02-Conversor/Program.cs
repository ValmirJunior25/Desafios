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
                        
                        if (escolha == "1")
                        {
                            string unidadeDeMedida = "Celsius";
                            double numero = LerValorValido(unidadeDeMedida);
                            double valorConvertido = CelsiusFahrenheit(numero, unidadeDeMedida);

                            Console.WriteLine($"{numero}°C = {valorConvertido:F2}°F");
                        }

                        else if (escolha == "2")
                        {
                            string unidadeDeMedida = "Fahrenheit";
                            double numero = LerValorValido(unidadeDeMedida);
                            double valorConvertido = CelsiusFahrenheit(numero, unidadeDeMedida);

                            Console.WriteLine($"{numero}°F = {valorConvertido:F2}°C");
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
                            string unidadeDeMedida = "Quilômetros";
                            double numero = LerValorValido(unidadeDeMedida);
                            double valorConvertido = QuilometrosMilhas(numero, unidadeDeMedida);

                            Console.WriteLine($"{numero}Km = {valorConvertido:F2} Milhas");
                        }

                        else if (escolha == "2")
                        {
                            string unidadeDeMedida = "Milhas";
                            double numero = LerValorValido(unidadeDeMedida);
                            double valorConvertido = QuilometrosMilhas(numero, unidadeDeMedida);

                            Console.WriteLine($"{numero} Milhas = {valorConvertido:F2} Km");
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
                        Console.Write("[ 1 ] Quilogramas --> Libras \n[ 2 ] Libras --> Quilogramas \n\n--> "); 
                        string escolha = Console.ReadLine() ?? "";
                        string escolhatxt;
                        
                        if (escolha == "1")
                        {
                            string unidadeDeMedida = "Quilogramas";
                            double numero = LerValorValido(unidadeDeMedida);
                            double valorConvertido = QuilogramasLibras(numero, unidadeDeMedida);

                            Console.WriteLine($"{numero} Kg = {valorConvertido:F2} Lb");
                        }

                        else if (escolha == "2")
                        {
                            string unidadeDeMedida = "Libras";
                            double numero = LerValorValido(unidadeDeMedida);
                            double valorConvertido = QuilogramasLibras(numero, unidadeDeMedida);

                            Console.WriteLine($"{numero} Lb = {valorConvertido:F2} Kg");
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

    static double LerValorValido(string unidadeDeMedida)
    {
        while (true)
        {
            Console.Write($"Digite o valor em {unidadeDeMedida}: ");
            string numDigitado = Console.ReadLine();
            if (double.TryParse(numDigitado, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
            {
                return valor;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Valor invalido! Tente novamente.");
            } 
        }
    }


    static double CelsiusFahrenheit(double numero, string unidadeDeMedida)
    {
        if (unidadeDeMedida == "Celsius")
        {
            double fahrenheit = (numero * 1.8) + 32;
            return fahrenheit;
        }
        else if(unidadeDeMedida == "Fahrenheit")
        {
            double celsius = (numero - 32) / 1.8;
            return celsius;
        }
        else
        {
            throw new ArgumentException("Unidade inválida");
        }

    }


    static double QuilometrosMilhas(double numero, string unidadeDeMedida)
    {
        if (unidadeDeMedida == "Quilômetros")
        {
            double milhas = numero * 0.621371;
            return milhas;
        }
        else if(unidadeDeMedida == "Milhas")
        {
            double quilometros = numero / 0.621371;
            return quilometros;
        }
        else
        {
            throw new ArgumentException("Unidade inválida");
        }

    }

    static double QuilogramasLibras(double numero, string unidadeDeMedida)
    {
         if (unidadeDeMedida == "Quilogramas")
        {
            double libras = numero * 2.20462;
            return libras;
        }
        else if(unidadeDeMedida == "Libras")
        {
            double Quilogramas = numero / 2.20462;
            return Quilogramas;
        }
        else
        {
            throw new ArgumentException("Unidade inválida");
        }
    }
}