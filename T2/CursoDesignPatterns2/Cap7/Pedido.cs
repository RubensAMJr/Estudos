using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7 {
    class Pedido {
        public string Cliente { get; private set; }

        public double ValorDoPedido { get; private set; }

        public DateTime DataFinalizacao { get; private set; }

        public Status Status { get; private set; }

        public Pedido(string cliente, double valorDoPedido) {
            Cliente = cliente;
            ValorDoPedido = valorDoPedido;
            this.Status = Status.Novo;
        }

        public void Paga() {
            this.Status = Status.Pago;
        }

        public void Finaliza() {
            this.Status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }


    }
}
