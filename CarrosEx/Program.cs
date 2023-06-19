using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosEx;

Console.WriteLine("Sistema de cadastro de carros");
Console.Write("Digite o número do motor: ");
string motor = Console.ReadLine();
Console.Write("Digite o chassi: ");
string chassi = Console.ReadLine();
Console.Write("Digite o custo da produção: ");
decimal custoProducao = Convert.ToDecimal(Console.ReadLine());
Console.Write("Qual o tipo do carro? Flex, Diesel ou Elétrico? ");
string tipoCarro = Console.ReadLine();

switch (tipoCarro)
{
    case "Flex":
        Console.Write($"Digite o número de portas: ");
        int numPortas = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Digite o número de cilindradas: ");
        decimal numCilindradas = Convert.ToDecimal(Console.ReadLine());
        CarroFlex carro = new CarroFlex(chassi, motor, custoProducao, numPortas, numCilindradas);
        Console.WriteLine($"Valor obtido: {carro.CalcularCustoVenda()}");
        break;

    case "Diesel":
        Console.Write($"Capacidade de carga: ");
        decimal capacidadeCarga = Convert.ToDecimal(Console.ReadLine());
        Console.Write($"Volume de cacamba: ");
        decimal volumeCacamba = Convert.ToDecimal(Console.ReadLine());
        CarroDiesel carroDiesel = new CarroDiesel(
            chassi,
            motor,
            custoProducao,
            capacidadeCarga,
            volumeCacamba
        );
        Console.WriteLine($"Valor obtido: {carroDiesel.CalcularCustoVenda()}");
        break;
    case "Elétrico":
        Console.Write($"Potência: ");
        decimal potencia = Convert.ToDecimal(Console.ReadLine());
        Console.Write($"Duração da bateria: ");
        decimal duracaoBateria = Convert.ToDecimal(Console.ReadLine());
        CarroEletrico carroEletrico = new CarroEletrico(
            chassi,
            motor,
            custoProducao,
            potencia,
            duracaoBateria
        );
        Console.WriteLine($"Valor obtido: {carroEletrico.CalcularCustoVenda()}");
        break;
    default:
        Console.WriteLine($"Texto inválido");
        break;
}
