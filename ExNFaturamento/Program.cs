using System.Globalization;
using ExNFaturamento;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantidade de dias: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine($"Não é possível realizar a operação!");
            
        }
        else
        {
            
            List<Faturamento> list = new List<Faturamento>();

            for (int i = 1; i <= n; i++)
            {
            System.Console.WriteLine($"Dia {i}:");
            int dia = 0;
            dia += i;
            System.Console.Write($"Total faturado: ");
            double faturadoDia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new Faturamento(dia, faturadoDia));
            System.Console.WriteLine();
            }
            System.Console.WriteLine("Faturado: ");
            foreach (Faturamento item in list)
            {
            System.Console.WriteLine(item);
            }
            
        }
    }
}