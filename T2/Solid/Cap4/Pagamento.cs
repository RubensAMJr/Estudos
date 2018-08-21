namespace Solid.Cap4
{
    public class Pagamento
    {
        public double Valor;
        private MeioDePagamento meio;

        public Pagamento(double valor, MeioDePagamento meio)
        {
            this.Valor = valor;
            this.meio = meio;
        }
    }
}