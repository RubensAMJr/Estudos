using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns {
    public class ICCC : IImposto {

        public ICCC(IImposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }
        public override double Calcula(Orcamento orcamento) {
            if (orcamento.Valor < 1000) {
                return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
            }else if(orcamento.Valor > 1000 && orcamento.Valor < 3000){
                return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
            }
            else {
                return orcamento.Valor * 0.18 + 30;
            }
        }
    }
}
