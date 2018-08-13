﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns {
    public abstract class IImposto {


        public IImposto OutroImposto { get; private set; }

        public IImposto(IImposto outroImposto) {
            OutroImposto = outroImposto;
        }

        protected IImposto() {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento) {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }


    }
}
