using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CalcImposto {
    public class Reprovado : EstadoDeUmOrcamento {
        public void AplicaDescontoExtra(Orcamento orcamento) {
            throw new Exception("Orcamentos reprovados não recebem desconto");
        }

        public void Aprova(Orcamento orcamento) {
            throw new Exception("Orçamento ja Reprovado");
        }

        public void Finaliza(Orcamento orcamento) {
            throw new NotImplementedException();
        }

        public void Reprova(Orcamento orcamento) {
            throw new Exception("Orçamento Ja Reprovado");
        }
    }
}
