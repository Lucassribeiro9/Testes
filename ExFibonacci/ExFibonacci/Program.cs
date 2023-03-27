internal class Program
{
    private static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 1;
        int aux;

        Console.WriteLine($"Sequência de Fibonacci");
        Console.Write("Informe um valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < valor; i++)
        {
            aux = n1;
            n1 = n2;
            n2 = n1 + aux;
            Console.Write("Sequência: {0}, ", n2);

            if (valor == aux || valor == n2)
            {
                
                Console.WriteLine("Número dentro da sequência");
                break;
            }
            else
            {
                Console.WriteLine("Fora da sequência");
                Console.ReadKey();
            }
        }
        
        

        /*while (valor > n3)
         {
             n3 = n1 + n2;
             n1 = n2;
             n2 = n3;

             if (valor == 0 || valor == 1)
             {
                 Console.WriteLine("Valor está dentro da sequência");
             }
             else if (valor == n3)
             {
                 Console.WriteLine("Valor está dentro da sequência");
             }
             else
             {
                 Console.WriteLine("Valor não está dentro da sequência");
             }
         } */


    }
}