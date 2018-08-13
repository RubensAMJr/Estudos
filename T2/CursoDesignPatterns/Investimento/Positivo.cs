using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    public class Positivo : EstadoDeUmaConta {
        public void Deposita(ContaBancaria conta, double valor) {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.EstadoAtual = new Negativo();
        }

        public void Saca(ContaBancaria conta, double valor) {
            conta.Saldo += valor * 0.98;
        }
    }
}
