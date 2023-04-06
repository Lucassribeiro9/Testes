using ExFaturamento;
using System;
using System.Diagnostics;

    Faturamento[] vect = new Faturamento[5];
    Console.Write("Quantidade de dias: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
        {
            Console.Write("Digite o dia:");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o faturamento: ");
            double faturamento = Convert.ToDouble(Console.ReadLine());
            vect[n] = new Faturamento(faturamento, dia);
        }
    Console.WriteLine();
    Console.WriteLine("Dias faturados: ");
    foreach (Faturamento obj in vect)
        {
            Console.WriteLine(obj);
        }
   