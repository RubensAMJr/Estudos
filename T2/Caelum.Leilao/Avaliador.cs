using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;
        public double MaiorLance { get { return maiorDeTodos; } }
        public double MenorLance { get { return menorDeTodos; } }
        private List<Lance> maiores;

        public void Avalia(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                if (lance.Valor > maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }
                if (lance.Valor < menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
            }
            pegaOsMaioresNo(leilao);
        }

        private void pegaOsMaioresNo(Leilao leilao)
        {
            maiores = new List<Lance>(leilao.Lances.OrderByDescending(x => x.Valor));
            maiores = maiores.GetRange(0, maiores.Count > 3 ? 3 : maiores.Count);
        }

        public List<Lance> TresMaiores
        {
            get { return this.maiores; }
        }

        public double Media(Leilao leilao)
        {
            int qnt = 0;
            double media = 0;
            foreach (var lance in leilao.Lances)
            {
                media += lance.Valor;
                qnt++;
            }
            return media / qnt;
        }
        

    }
}
