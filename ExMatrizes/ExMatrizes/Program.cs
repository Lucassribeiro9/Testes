Console.Write("Quantidade de elementos: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(espaco[j]);
    }
}
Console.WriteLine("Diagonal: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(mat[i, i] + " ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine($"Número negativo: {count}");
