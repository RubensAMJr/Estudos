using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CalcImposto {
    public class NotaFiscalBuilder {


        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        public string Observacoes { get; private set; }
        public DateTime NaDataAtual { get; private set; } = DateTime.Now;
        public IList<AcaoAposGerarNota> Acoes { get; private set; }

        public NotaFiscalBuilder()
        {
            
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, NaDataAtual, ValorTotal, Impostos, todosItens, Observacoes);

            foreach (var acao in Acoes)
            {
                acao.Executa(nf);
            }
            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.Acoes.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial) {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacao) {
            this.Observacoes = observacao;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data) {
            this.NaDataAtual = data;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj) {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder comItem(ItemDaNota item) {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }

}

