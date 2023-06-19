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
        Carro carro = new CarroFlex(motor, chassi, custoProducao);
        break;
    case "Diesel":
        Carro carro = new CarroDiesel(motor, chassi, custoProducao);
        break;
    case "Elétrico":
        Carro carro = new CarroEletrico(motor, chassi, custoProducao);
        break;
    default:
        Console.WriteLine($"Texto inválido");
        break;
}
