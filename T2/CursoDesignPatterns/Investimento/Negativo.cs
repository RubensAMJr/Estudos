using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    public class Negativo : EstadoDeUmaConta {
        public void Deposita(ContaBancaria conta, double valor) {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.EstadoAtual = new Positivo();
        }

        public void Saca(ContaBancaria conta, double valor) {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }
    }
}
