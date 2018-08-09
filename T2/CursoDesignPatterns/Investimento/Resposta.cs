using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimento {
    public interface Resposta {

        void Responde(ContaBancaria conta, Requisicao requisicao);
        Resposta outraResposta { get; set; }
    }
}
