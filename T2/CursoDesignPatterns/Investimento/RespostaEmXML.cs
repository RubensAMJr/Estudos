using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    public class RespostaEmXML : Resposta {
        public Resposta outraResposta { get; set ; }

        public void Responde(ContaBancaria conta, Requisicao requisicao) {
            if (requisicao.Formato == Formato.XML) {
                Console.WriteLine("<conta><titular>" + conta.Nome + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else {
                outraResposta.Responde(conta, requisicao);
            }
        }
    }
}
