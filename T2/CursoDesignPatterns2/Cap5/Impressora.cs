using CursoDesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap5
{
    public class Impressora
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Aceita(this);
            Console.Write("+");
            soma.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubstracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Aceita(this);
            Console.Write("-");
            subtracao.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);

            
        }
    }
}
