using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Imposto {
    public class ICPP : TemplateDeImpostoCondicional {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) {
            return orcamento.Valor >= 500;

        }



        public override double MaximaTaxacao(Orcamento orcamento) {
            return orcamento.Valor * 0.07;
        }



        public override double MinimaTaxacao(Orcamento orcamento) {
            return orcamento.Valor * 0.05;
        }

        private bool ItemMaiorQue100(Orcamento orcamento) {
            foreach (var item in orcamento.itens) {
                if (item.Valor > 100) {
                    return true;
                }
            }
            return false;
        }
    }
}
