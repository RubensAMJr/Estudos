using System;
using System.Collections.Generic;

namespace Solid.Cap4
{
    public class Fatura
    {
        private IList<Pagamento> pagamentos;
        public double Valor { get; internal set; }
        public bool Pago { get; internal set; }

        public Fatura(IList<Pagamento> pagamentos, double valor, bool pago)
        {
            pagamentos = new List<Pagamento>();
            Valor = valor;
            Pago = pago;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
           pagamentos.Add(pagamento);

            if (valorTotalDosPagamentos() >= Valor)
            {
                Pago = true;
            }

        }

        private double valorTotalDosPagamentos()
        {
            double total = 0;

            foreach (var pagamento in pagamentos)
            {
                total += pagamento.Valor;
            }

            return total; 
        }
    }
}