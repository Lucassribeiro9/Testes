namespace ExMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de elementos: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("Informe o elemento ({0},{1}): ", i, j));
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(mat[i, j]);

                }
            }


        }
    }

}