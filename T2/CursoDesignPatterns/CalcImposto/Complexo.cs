using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Imposto {
    class Complexo : TemplateRelatorio {
        public override void ImprimeRelatorio(Relatorio relatorio) {
            Console.Write(relatorio.Titular + relatorio.Saldo + relatorio.Agencia+ relatorio.NumeroConta);
        }
    }
}
