using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Imposto {
    class DescontoPorCincoItens : IDesconto{
        public IDesconto Proximo { get ; set; }

        public double Desconta(Orcamento orcamento) {

            if (orcamento.itens.Count > 5) {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconta(orcamento);

        }
    }
}
