using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    class RespostaEmCsv : Resposta {
        public Resposta outraResposta { get ; set ; }

        public void Responde(ContaBancaria conta, Requisicao req) {
            if (req.Formato == Formato.CSV) {
                Console.WriteLine(conta.Nome + ";" + conta.Saldo);
            }
            else {
                outraResposta.Responde(conta,req);
            }
        }
    }
}
