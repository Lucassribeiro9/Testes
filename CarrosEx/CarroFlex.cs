using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosEx
{
    public class CarroFlex : Carro
    {
        public int NumPortas { get; set; }
        public decimal NumCilindradas { get; set; }

        public override decimal CalcularCustoVenda()
        {
            decimal imposto = CustoProducao * 0.2m;
            decimal lucro = CustoProducao * 0.25m;
            return CustoProducao + imposto + lucro;
        }
    }
}