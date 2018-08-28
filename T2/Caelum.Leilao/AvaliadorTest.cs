using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{


    [TestFixture]
    public class AvaliadorTest
    {
    private Avaliador leiloeiro;

    [SetUp]
    public void CriaAvaliador()
    {
            this.leiloeiro = new Avaliador();
    }
        [Test]
        public void Main()
        {
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));
            leilao.Propoe(new Lance(maria, 250.0));

            leiloeiro.Avalia(leilao);

            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, 0.0001);
           
        }

        [Test]
        public void TestaMedia()
        {
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));
            leilao.Propoe(new Lance(maria, 250.0));


            double esperado = 316;
            double resultado = leiloeiro.Media(leilao);
            

            Assert.AreEqual(esperado, resultado, 1);
            
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Usuario joao = new Usuario("João");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 100.0));
            leilao.Propoe(new Lance(maria, 200.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));

            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
        }

        [Test]
        public void ApenasUm()
        {
            Usuario joao = new Usuario("Joao");
            Leilao leilao = new Leilao("Playstation 3 Novo");
            leilao.Propoe(new Lance(joao, 300.0));
            leiloeiro.Avalia(leilao);
            double maiorEsperado = 300;
            double menorEsperado = 300;
            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, 0.0001);
        }

        [Test]
        public void ValoresAleatorios()
        {
            Usuario joao = new Usuario("Joao");
            Usuario joao2 = new Usuario("Joao2");
            Usuario joao3 = new Usuario("Joao3");
            Usuario joao4 = new Usuario("Joao4");
            Usuario joao5 = new Usuario("Joao5");
            Usuario joao6 = new Usuario("Joao6");
            Leilao leilao = new Leilao("Playstation 3 Novo");
            leilao.Propoe(new Lance(joao, 200.0));
            leilao.Propoe(new Lance(joao2, 450.0));
            leilao.Propoe(new Lance(joao3, 120.0));
            leilao.Propoe(new Lance(joao4, 700.0));
            leilao.Propoe(new Lance(joao5, 630.0));
            leilao.Propoe(new Lance(joao6, 230.0));
            leiloeiro.Avalia(leilao);
            double maiorEsperado = 120;
            double menorEsperado = 700;
            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, 0.0001);
        }

        [Test]
        public void ValoresDecrescente()
        {
            Usuario joao = new Usuario("Joao");
            Usuario joao2 = new Usuario("Joao2");
            Usuario joao3 = new Usuario("Joao3");
            Usuario joao4 = new Usuario("Joao4");
            Leilao leilao = new Leilao("Playstation 3 Novo");
            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(joao2, 300.0));
            leilao.Propoe(new Lance(joao3, 200.0));
            leilao.Propoe(new Lance(joao4, 100.0));
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);
            double maiorEsperado = 400;
            double menorEsperado = 100;
            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, 0.0001);

        }

        [Test]
        public void QuatroLances()
        {
            Usuario joao = new Usuario("Joao");
            Usuario joao2 = new Usuario("Joao2");
            Usuario joao3 = new Usuario("Joao3");
            Usuario joao4 = new Usuario("Joao4");
            Leilao leilao = new Leilao("Playstation 3 Novo");
            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(joao2, 300.0));
            leilao.Propoe(new Lance(joao3, 200.0));
            leilao.Propoe(new Lance(joao4, 100.0));
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);
            List<Lance> resultado = leiloeiro.TresMaiores;
            Assert.AreEqual(400, resultado[0].Valor, 0.0001);
            Assert.AreEqual(300, resultado[1].Valor, 0.0001);
            Assert.AreEqual(200, resultado[2].Valor, 0.0001);

        }

        [Test]
        public void DoisLances()
        {
            Usuario joao = new Usuario("Joao");
            Usuario joao2 = new Usuario("Joao2");
            Leilao leilao = new Leilao("Playstation 3 Novo");
            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(joao2, 300.0));
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);
            List<Lance> resultado = leiloeiro.TresMaiores;
            Assert.AreEqual(400, resultado[0].Valor, 0.0001);
            Assert.AreEqual(300, resultado[1].Valor, 0.0001);
            

        }

        [Test]
        public void NenhumLance()
        {
            
            Leilao leilao = new Leilao("Playstation 3 Novo");
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);
            List<Lance> resultado = leiloeiro.TresMaiores;
            Assert.AreEqual(0, resultado[0].Valor, 0.0001);
        }

        [Test]
        public void NaoDeveAvaliarLeiloesSemNenhumLanceDado()
        {
            Leilao leilao = new LeilaoBuilder()
                .Para("Playstation 3 Novo")
                .Constroi();

            leiloeiro.Avalia(leilao);

        }





    }
}
