using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6 {
    class MensagemAdministrador : IMensagem {
        public IEnviador Enviador { get ; set ; }

        public void Envia() {

        }

        public string Formata() {
        }
    }
}
