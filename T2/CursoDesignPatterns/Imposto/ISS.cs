using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns {
    class ISS : IImposto {

        public double Calcula(Orcamento orcamento) {
            return orcamento.Valor * 0.06;
        }
    }
}
