﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosEx;
using CarrosEx.Classes;
using CarrosEx.Services;

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Sistema de cadastro de carros");

    string motor = "";
    while (motor == "")
    {
        Console.Write("Digite o número do motor: ");
        motor = Console.ReadLine();

        if (motor == "")
        {
            Console.WriteLine("Erro: Campo obrigatório. Digite o número do motor novamente.");
        }
    }

    string chassi = "";
    while (chassi == "")
    {
        Console.Write("Digite o chassi: ");
        chassi = Console.ReadLine();

        if (chassi == "")
        {
            Console.WriteLine("Erro: Campo obrigatório. Digite o chassi novamente.");
        }
    }

    decimal custoProducao = 0;
    bool entradaValida = false;
    while (!entradaValida)
    {
        Console.Write("Digite o custo da produção: R$");

        try
        {
            custoProducao = Convert.ToDecimal(Console.ReadLine());
            entradaValida = true;
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Erro: Entrada inválida. Digite um número válido. {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    int tipoCarro = 0;
    while (tipoCarro != 1 && tipoCarro != 2 && tipoCarro != 3)
    {
        Console.Write("Qual o tipo do carro? [1]Flex,[2]Diesel ou [3]Elétrico? ");
        tipoCarro = Convert.ToInt32(Console.ReadLine());
        switch (tipoCarro)
        {
            case 1:
                int numPortas = 0;
                while (numPortas == 0)
                {
                    Console.Write($"Digite o número de portas: ");
                    string input = Console.ReadLine();

                    if (!Int32.TryParse(input, out numPortas))
                    {
                        Console.WriteLine("Erro: Entrada inválida. Digite um número inteiro válido.");
                    }
                    if (numPortas == 0)
                    {
                        Console.WriteLine("Erro: Campo obrigatório. Digite o número de portas novamente.");
                    }

                }
                decimal numCilindradas = 0;
                entradaValida = false;
                while (!entradaValida)
                {
                    Console.Write($"Digite o número de cilindradas: ");
                    try
                    {
                        numCilindradas = Convert.ToDecimal(Console.ReadLine());
                        entradaValida = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Erro: Entrada inválida. Digite um número válido.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e.Message}");
                    }
                }
                CarroFlex carro = new CarroFlex(chassi, motor, custoProducao, numPortas, numCilindradas, new CalcularImpostoService());
                decimal custoVenda = carro.CalcularCustoVenda(custoProducao);
                Console.WriteLine($"Valor obtido: R${custoVenda}");
                break;

            case 2:
                Console.Write($"Capacidade de carga: ");
                decimal capacidadeCarga = Convert.ToDecimal(Console.ReadLine());
                Console.Write($"Volume de cacamba: ");
                decimal volumeCacamba = Convert.ToDecimal(Console.ReadLine());
                CarroDiesel carroDiesel = new CarroDiesel(
                    chassi,
                    motor,
                    custoProducao,
                    capacidadeCarga,
                    volumeCacamba,
                    new CalcularImpostoService()
                );
                Console.WriteLine($"Valor obtido: R${CalcularCustoVendaCarroDiesel(carroDiesel.custoProducao)}");
                break;
            case 3:
                Console.Write($"Potência: ");
                decimal potencia = Convert.ToDecimal(Console.ReadLine());
                Console.Write($"Duração da bateria: ");
                decimal duracaoBateria = Convert.ToDecimal(Console.ReadLine());
                CarroEletrico carroEletrico = new CarroEletrico(
                    chassi,
                    motor,
                    custoProducao,
                    potencia,
                    duracaoBateria,
                    new CalcularImpostoService()
                );
                Console.WriteLine($"Valor obtido: R${CalcularCustoVendaCarroEletrico(custoProducao)}");
                break;
            default:
                Console.WriteLine($"Texto inválido. Digite um texto válido.");
                break;
        }
    }

    Console.Write("Deseja continuar? (S/N) ");
    string resposta = Console.ReadLine();

    if (resposta.ToUpper() != "S")
    {
        continuar = false;
        Console.WriteLine("Encerrando...");
    }
}