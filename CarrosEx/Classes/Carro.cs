using CarrosEx.Services;

namespace CarrosEx
{
    public abstract class Carro
    {
        private readonly CalcularImpostoService _calcularImpostoService;

        public string NumChassi { get; set; }
        public string NumMotor { get; set; }
        public decimal CustoProducao { get; set; }

        public Carro(string numChassi, string numMotor, decimal custoProducao, CalcularImpostoService calcularImpostoService)
        {
            NumChassi = numChassi;
            NumMotor = numMotor;
            CustoProducao = custoProducao;
            _calcularImpostoService = calcularImpostoService;
        }

        public virtual decimal CalcularCustoVenda()
        {
            return _calcularImpostoService.CalcularCustoVenda(CustoProducao);
        }
    }
}
