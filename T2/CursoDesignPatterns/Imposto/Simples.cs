using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Imposto {
    class Simples : TemplateRelatorio {
        public override void ImprimeRelatorio(Relatorio relatorio) {
            Console.Write(relatorio.Titular+relatorio.Saldo);
        }
    }
}
