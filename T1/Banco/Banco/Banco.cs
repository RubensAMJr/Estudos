using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    class Banco {

        public Conta[] contas = new Conta[10];
        public int indice = 0;


        public void Adiciona(Conta conta) {


            contas[indice] = conta;
            indice++;
        }
    }
}
