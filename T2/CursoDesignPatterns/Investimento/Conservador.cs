using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    class Conservador : IInvestimento {
        public double Investe(double saldo) {
            return saldo * 0.08;
        }
    }
}
