using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class Conta {

        public double saldo { get; set; }
        public Cliente titular { get; set; }          
        public int numero { get; set; }

        public Conta(double saldo, Cliente titular, int numero) {
            this.saldo = saldo;
            this.titular = titular;
            this.numero = numero;
        }

        public Conta() {
        }

        public void saca(double valor) {

            
                  this.saldo -= valor;

            
        }

        public virtual void deposita(double valor) {
            this.saldo += valor;
        }

        public void transfere(double valor , Conta recebe) {
            this.saca(valor);
            recebe.deposita(valor);
        }

       




    }
}
