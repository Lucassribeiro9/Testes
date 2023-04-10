using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantidade de dias: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Faturamento[] vect = new Faturamento[n];

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
    }
}