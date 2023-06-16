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
    }
}