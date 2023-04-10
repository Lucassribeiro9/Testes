using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ExNFaturamento
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public double FaturadoDia { get; set; }

        public Faturamento(int dia, double faturadoDia)
        {
            Dia = dia;
            FaturadoDia = faturadoDia;
        }
        public override string ToString() {
            return "Dia "+ Dia
                + ", R$"
                + FaturadoDia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}