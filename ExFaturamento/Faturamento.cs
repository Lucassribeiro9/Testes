using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ExFaturamento
{
    public class Faturamento
    {
        public double FaturamentoDia { get; set; }
        public int Dia { get; set; }

        public Faturamento(double faturamento, int dia)
        {
            FaturamentoDia = faturamento;
            Dia = dia;
        }

        public override string ToString()
        {
            return "Dia: " + Dia + ", Faturamento: " + FaturamentoDia;
        }
    }
}