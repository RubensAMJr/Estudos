using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Imposto {
    public class Relatorio {

        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }
    }
}
