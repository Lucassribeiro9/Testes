/*
 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a 
sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 1;
        int aux;

        Console.WriteLine("Sequência de Fibonacci");
        Console.Write("Informe um valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < valor; i++)
        {
            aux = n1;
            n1 = n2;
            n2 = n1 + aux;
            Console.WriteLine();
            Console.Write("{0}, ", n2);
            if (valor == aux || valor == n2)
            {
                Console.WriteLine();
                Console.WriteLine("Número dentro da sequência");
                break;
            }
            else
            {
                Console.WriteLine("Fora da sequência");
                Console.ReadKey();
            }
        }
    }
}