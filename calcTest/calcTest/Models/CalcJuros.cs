using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calcTest.Models
{
    public static class CalcJuros
    {
        public static Decimal valorInicial { get; set; } = 0;
        public static Decimal valorFinal { get; set; } = 0;
        public static Int32 tempoMeses { get; set; } = 0;
        public const Decimal valorJuros = 1;
    }
}
