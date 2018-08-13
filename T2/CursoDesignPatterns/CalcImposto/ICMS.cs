using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns {
    public class ICMS : IImposto{

        public ICMS(IImposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double Calcula(Orcamento orcamento) {
            return orcamento.Valor * CalculoDoOutroImposto(orcamento);
        }

        
    }
}
