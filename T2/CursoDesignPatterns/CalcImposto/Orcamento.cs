using CursoDesignPatterns.CalcImposto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns {
    public class Orcamento {

        public EstadoDeUmOrcamento EstadoAtual { get;set; }

        private int nmrDesconto;

        public double Valor { get; set; }
        public IList<Item> itens { get;  set; }

        public Orcamento(double valor) {
            Valor = valor;
            nmrDesconto = 0;
            this.itens = new List<Item>();
        }

        public void AplicaDescontoExtra() {
            if (nmrDesconto == 0) {
                EstadoAtual.AplicaDescontoExtra(this);
                nmrDesconto++;
            }
            else {
                throw new Exception("Desconto ja Aplicado");
            }
        }

        public void AdicionaItens(Item item) {
            itens.Add(item);
        }

        public void Aprova() {
            EstadoAtual.Aprova(this);
        }

        public void Reprova() {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza() {
            EstadoAtual.Finaliza(this);
        }
    }
}
