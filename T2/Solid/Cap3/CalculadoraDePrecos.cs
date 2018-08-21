using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco tabela { get; set; }
        private IServicoDeEntrega entrega { get; set; }
        
        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
            Frete correios = new Frete();

            double desconto = tabela.DescontoPara(produto.Valor);
            double frete = correios.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
