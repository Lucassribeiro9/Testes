using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosEx
{
    public class CarroDiesel : Carro
    {
        public decimal CapacidadeCarga { get; set; }
        public decimal VolumeCacamba { get; set; }

        public CarroDiesel(string numChassi, string numMotor, decimal custoProducao, decimal capacidadeCarga, decimal volumeCacamba) : base(numChassi, numMotor, custoProducao)
        {
            CapacidadeCarga = capacidadeCarga;
            VolumeCacamba = volumeCacamba;
        }
        public override decimal CalcularCustoVenda()
        {
            decimal imposto = CustoProducao * 0.3m;
            decimal lucro = CustoProducao * 0.25m;
            return CustoProducao + imposto + lucro;
        }
    }

}