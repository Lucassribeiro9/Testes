/* 
 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
 */

using System.Globalization;

double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;
double totalDistribuidora = sp + rj + mg + es + outros;

double psp = (sp / totalDistribuidora) * 100;
double prj = (rj / totalDistribuidora) * 100;
double pmg = (mg / totalDistribuidora) * 100;
double pes = (es / totalDistribuidora) * 100;
double pOutros = (outros / totalDistribuidora) * 100;


Console.WriteLine($"Total da distribuidora: R${totalDistribuidora.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine("Percentual dos estados");
Console.WriteLine($"São Paulo: {psp.ToString("F2", CultureInfo.InvariantCulture)}%");
Console.WriteLine($"Rio de Janeiro: {prj.ToString("F2", CultureInfo.InvariantCulture)}%");
Console.WriteLine($"Minas Gerais: {pmg.ToString("F2", CultureInfo.InvariantCulture)}%");
Console.WriteLine($"Espírito Santo: {pes.ToString("F2", CultureInfo.InvariantCulture)}%");
Console.WriteLine($"Outros estados: {pOutros.ToString("F2", CultureInfo.InvariantCulture)}%");

