using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    class ContaCorrente :Conta {


        public ContaCorrente(double saldo, Cliente titular, int numero) : base(saldo, titular, numero) {

        }

    }
}
