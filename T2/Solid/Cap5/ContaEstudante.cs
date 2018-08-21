using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap5
{
    public class ContaEstudante : ContaComum
    {

        public int Milhas { get; private set; }
        public ContaEstudante() : base()
        {

        }

        public override void SomaInvestimento()
        {
            throw new Exception("Conta de estudante não rende");
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
