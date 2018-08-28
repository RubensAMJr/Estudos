using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class AnoBissexto
    {

        public bool EhBissexto(int ano)
        {
            if ((ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
