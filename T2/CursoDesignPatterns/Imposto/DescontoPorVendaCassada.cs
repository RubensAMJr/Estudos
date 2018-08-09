using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Imposto {
    public class DescontoPorVendaCassada : IDesconto {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento) {
            if(Existe("CANETA",orcamento) && Existe("LAPIS", orcamento)) {
                return orcamento.Valor * 0.05;
            }
            else {
                return Proximo.Desconta(orcamento);
            }


        }

        private bool Existe(String nomeDoItem, Orcamento orcamento) {
            foreach (Item item in orcamento.itens){
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
