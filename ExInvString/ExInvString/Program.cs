﻿/* 
 5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
 */
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string s = "Teste Técnico";
        StringBuilder sb = new StringBuilder();

        for (var i = s.Length -1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        Console.WriteLine($"Normal: {s}");
        Console.WriteLine($"Invertido: {sb.ToString()}");
    }
}