using System;
namespace ExMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de elementos: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];

            for (int i = 0;i < n;i++)
            {
                string[] espaco = Console.ReadLine().Split(' ');
                for(int j = 0;j < n;j++)
                {
                    mat[i,j] = int.Parse(espaco[j]);
                }
            }
        }
    }

}