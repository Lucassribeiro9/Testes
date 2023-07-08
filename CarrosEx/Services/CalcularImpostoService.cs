using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosEx.Services
{
    public class CalcularImpostoService
    {
         public virtual decimal CalcularCustoVenda(decimal custoProducao)
        {
            decimal imposto = custoProducao * 0.2m;
            decimal lucro = custoProducao * 0.25m;
            return custoProducao + imposto + lucro;
        }
    }
}