using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosEx.Services;

namespace CarrosEx
{
    public class CarroEletrico : Carro
    {
        private readonly CalcularImpostoService _calcularImpostoService;

        public decimal Potencia { get; set; }
        public decimal DuracaoBateria { get; set; }

        public CarroEletrico(string numChassi, string numMotor, decimal custoProducao, decimal potencia, decimal duracaoBateria, CalcularImpostoService calcularImpostoService) : base(numChassi, numMotor, custoProducao, calcularImpostoService)
        {
            Potencia = potencia;
            DuracaoBateria = duracaoBateria;
            _calcularImpostoService = calcularImpostoService;
        }

        public override decimal CalcularCustoVenda()
        {
            return _calcularImpostoService.CalcularCustoVendaCarroEletrico(CustoProducao);
        }
    }
}