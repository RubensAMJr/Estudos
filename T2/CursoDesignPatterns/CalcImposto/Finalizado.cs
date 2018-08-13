using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CalcImposto {
    public class Finalizado : EstadoDeUmOrcamento {
        public void AplicaDescontoExtra(Orcamento orcamento) {
            throw new Exception("Orcamentos finalizados não recebem desconto");
        }

        public void Aprova(Orcamento orcamento) {
            throw new Exception("Ja Finalizado");
        }

        public void Finaliza(Orcamento orcamento) {
            throw new Exception("Ja Finalizado");
        }

        public void Reprova(Orcamento orcamento) {
            throw new Exception("Ja Finalizado");
        }
    }
}
