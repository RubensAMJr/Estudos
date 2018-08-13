
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CalcImposto {
    public class Aprovado : EstadoDeUmOrcamento {
        public void AplicaDescontoExtra(Orcamento orcamento) {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.2);
        }

        public void Aprova(Orcamento orcamento) {
            throw new Exception("Ja esta em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento) {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento) {
            throw new Exception("Orçamento ja está aprovado");
        }
    }
}
