using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class Cliente {

        public string nome;
        public int idade;
        public string cpf;
        public string rg;
        public string endereco;

        public Cliente(string nome, int idade, string cpf, string rg, string endereco) {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;
        }

        

        public Cliente(string nome) {
            this.nome = nome;
        }

        public Boolean ehMaiorDeIdade() {
            if(idade > 18) {
                return true;
            }
            else {
                return false;
            }

        }


    }
}
