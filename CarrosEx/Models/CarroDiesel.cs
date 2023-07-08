using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosEx.Services;

namespace CarrosEx
{
    public class CarroDiesel : Carro
    {
        private readonly CalcularImpostoService _calcularImpostoService;

        public decimal CapacidadeCarga { get; set; }
        public decimal VolumeCacamba { get; set; }

        public CarroDiesel(string numChassi, string numMotor, decimal custoProducao, decimal capacidadeCarga, decimal volumeCacamba, CalcularImpostoService calcularImpostoService) : base(numChassi, numMotor, custoProducao, calcularImpostoService)
        {
            CapacidadeCarga = capacidadeCarga;
            VolumeCacamba = volumeCacamba;
            _calcularImpostoService = calcularImpostoService;
        }
        public override decimal CalcularCustoVenda()
        {
            return _calcularImpostoService.CalcularCustoVendaCarroDiesel(CustoProducao);
        }
    }

}