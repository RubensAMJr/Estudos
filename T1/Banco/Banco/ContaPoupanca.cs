using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class ContaPoupanca : Conta , ITributavel{

        

        

        public ContaPoupanca(double saldo, Cliente titular, int numero) : base(saldo,titular,numero){

        }

        public double calculaTributo() {
            return this.Saldo * 0.02;
        }

        public override void deposita(double valor) {
            this.Saldo += valor + 0.1;
        }
    }
}
