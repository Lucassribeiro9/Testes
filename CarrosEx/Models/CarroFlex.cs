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
    
    public CarroFlex(string numChassi, string numMotor, decimal custoProducao, int numPortas, decimal numCilindradas) : base(numChassi, numMotor, custoProducao)   
    {
        NumPortas = numPortas;
        NumCilindradas = numCilindradas;
    }
        public override decimal CalcularCustoVenda()
        {
            decimal imposto = CustoProducao * 0.2m;
            decimal lucro = CustoProducao * 0.25m;
            return CustoProducao + imposto + lucro;
        }
    }
}