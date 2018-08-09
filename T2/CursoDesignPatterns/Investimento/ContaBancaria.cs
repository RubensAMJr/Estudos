namespace CursoDesignPatterns {
    public class ContaBancaria {

        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, double saldo) {
            Nome = nome;
            Saldo = saldo;
        }


    }


}