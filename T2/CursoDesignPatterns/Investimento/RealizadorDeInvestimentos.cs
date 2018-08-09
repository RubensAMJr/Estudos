using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns {
    class RealizadorDeInvestimentos {

        public void realizaInvestimento(ContaBancaria conta ,IInvestimento investimento) {
            conta.Saldo = investimento.Investe(conta.Saldo); 
        }
    }

    
}
