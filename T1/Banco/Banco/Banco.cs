using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    class Banco {

        public Conta[] contas = new Conta[10];
        public int Indice = 0;


        public void Adiciona(Conta conta) {


            contas[Indice] = conta;
            Indice++;
        }
    }
}
