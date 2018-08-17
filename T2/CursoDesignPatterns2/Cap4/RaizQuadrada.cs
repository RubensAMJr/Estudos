using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;
       

        public RaizQuadrada(IExpressao expressao)
        {
            this.expressao = expressao;
        }

        public int Avalia()
        {
            
            
            return (int) Math.Sqrt(expressao.Avalia());
        }
    }
}
