using CursoDesignPatterns.Investimento;

namespace CursoDesignPatterns {
    public class ContaBancaria {

        public EstadoDeUmaConta EstadoAtual;

        public string Nome { get; private set; }
        public double Saldo { get;  set; }

        public ContaBancaria(string nome, double saldo) {
            Nome = nome;
            Saldo = saldo;
            if (Saldo > 0) {
                EstadoAtual = new Positivo();
            }
            else {
                EstadoAtual = new Negativo();
            }
        }

        public void Saca(double valor) {
            EstadoAtual.Saca(this,valor);
        }

        public void Deposita(double valor) {
            EstadoAtual.Deposita(this, valor);
        }




    }


}