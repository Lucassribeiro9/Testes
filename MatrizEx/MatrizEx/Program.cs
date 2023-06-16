namespace MatrizEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de colunas: ");
            int colunas = int.Parse(Console.ReadLine());
            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite o elemento [{i}, {j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                }
            }
            int par = 0;
            int impar = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }
                }
            }
            if (par > impar)
            {
                Console.WriteLine("Quantidade de números pares: " + par);

            }
            else
            {
                Console.WriteLine("Quantidade de números ímpares: " + impar);

            }
        }
    }
}