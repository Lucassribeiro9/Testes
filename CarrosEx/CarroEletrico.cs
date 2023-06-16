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
    }
}