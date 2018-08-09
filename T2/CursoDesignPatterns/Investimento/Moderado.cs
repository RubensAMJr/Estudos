using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    class Moderado : IInvestimento {
        public double Investe(double saldo) {
            bool escolhido = new Random().Next(101) > 50;
            if (escolhido) {
                return saldo * 0.25;
            }
            else {
                return saldo * 0.7;
            }
        }

    }
}
