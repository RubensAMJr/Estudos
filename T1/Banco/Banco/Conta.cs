using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {




    public class Conta {

        private double saldo;
        
        public double Saldo {
            get {
                return saldo;

            }
            set {
                this.saldo = value;

            }

        }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }

        public Conta(double saldo, Cliente titular, int numero) {
            this.Saldo = saldo;
            this.Titular = titular;
            this.Numero = numero;
        }

        public Conta() {
        }

        public void saca(double valor) {


            this.saldo -= valor;


        }

        public virtual void deposita(double valor) {
            this.saldo += valor;
        }

        public void transfere(double valor, Conta recebe) {
            this.saca(valor);
            recebe.deposita(valor);
        }






    }
}
