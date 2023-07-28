using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosEx.Services;

namespace CarrosEx.Classes
{
    public class CarroFlex : Carro
    {
        private readonly CalcularImpostoService _calcularImpostoService;
        public int NumPortas { get; set; }
        public decimal NumCilindradas { get; set; }

        public CarroFlex(string numChassi, string numMotor, decimal custoProducao, int numPortas, decimal numCilindradas, CalcularImpostoService calcularImpostoService) : base(numChassi, numMotor, custoProducao, calcularImpostoService)
        {
            NumPortas = numPortas;
            NumCilindradas = numCilindradas;
            _calcularImpostoService = calcularImpostoService;
        }
        public override decimal CalcularCustoVenda()
        {
            return _calcularImpostoService.CalcularCustoVenda(CustoProducao);
        }
    }
}