using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosEx
{
    public class CarroEletrico : Carro
    {
        public decimal Potencia { get; set; }
        public decimal DuracaoBateria { get; set; }

        public CarroEletrico(string numChassi, string numMotor, decimal custoProducao, decimal potencia, decimal duracaoBateria) : base(numChassi, numMotor, custoProducao)
        {
            Potencia = potencia;
            DuracaoBateria = duracaoBateria;
        }

        public override decimal CalcularCustoVenda()
        {
            decimal imposto = CustoProducao * 0.1m;
            decimal lucro = CustoProducao * 0.25m;
            return CustoProducao - imposto + lucro;
        }
    }
}