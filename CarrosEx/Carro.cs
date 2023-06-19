using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosEx
{
    public abstract class Carro
    {
        public string NumChassi { get; set; }
        public string NumMotor { get; set; }
        public decimal CustoProducao { get; set; }

        public Carro(string numChassi, string numMotor, decimal custoProducao)
        {
            NumChassi = numChassi;
            NumMotor = numMotor;
            CustoProducao = custoProducao;
        }

        public virtual decimal CalcularCustoVenda()
        {
            decimal imposto = CustoProducao * 0.2m;
            decimal lucro = CustoProducao * 0.25m;
            return CustoProducao + imposto + lucro;
        }
    }
}