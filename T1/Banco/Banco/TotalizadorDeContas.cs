using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class TotalizadorDeContas {
        public double Total { get; private set; }

        public void Acidiona(Conta conta) {
            this.Total += conta.Saldo;
        }

        

    }
}
