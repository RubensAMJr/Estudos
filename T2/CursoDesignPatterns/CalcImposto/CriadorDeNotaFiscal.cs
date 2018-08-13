using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CalcImposto {
    public class CriadorDeNotaFiscal {


        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscal

        public string Observacoes { get; private set; }
        public DateTime NaDataAtual { get; private set; }

        public void ParaEmpresa(String razaoSocial) {
            this.RazaoSocial = razaoSocial;
        }

        public void ComObservacoes(String observacao) {
            this.Observacoes = observacao;
        }

        public void NaDataArual() {
            this.NaDataAtual = DateTime.Now;
        }

        public void ComCnpj(String cnpj) {
            this.Cnpj = cnpj;
        }

        public void comItem(ItemDaNota item) {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
        }
    }

}

