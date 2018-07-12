using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class ContaPoupanca : Conta {

        

        

        public ContaPoupanca(double saldo, Cliente titular, int numero) : base(saldo,titular,numero){

        }

        

        public override void deposita(double valor) {
            this.saldo += valor + 0.1;
        }
    }
}
