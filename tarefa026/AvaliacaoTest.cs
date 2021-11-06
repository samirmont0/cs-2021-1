using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TesteAvaliacao;

namespace AvaliacaoTest
{
    [TestClass]
    public class UnitTest1
    {
        Avaliacao avaliacao = new Avaliacao();

        [TestMethod]
        [ExpectedException(typeof(ValoresInvalidosException),
            "Valores Inválidos.")]
        public void TestCenario1()
        {
            avaliacao.Avalia(6, 4, 5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ValoresInvalidosException),
            "Valores Inválidos.")]
        public void TestCenario2()
        {
            avaliacao.Avalia(6, 4, 0, 30);
            avaliacao.Avalia(6, 4, 10, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ValoresInvalidosException),
            "Valores Inválidos.")]
        public void TestCenario3()
        {
            avaliacao.Avalia(-2, 4, 5, 20);
            avaliacao.Avalia(11, 6, 5, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(ValoresInvalidosException),
            "Valores Inválidos.")]
        public void TestCenario4()
        {
            avaliacao.Avalia(4, -0.1, 3, 32);
            avaliacao.Avalia(2, 10.5, 6, 32);
        }

        [TestMethod]
        public void TestCenario5()
        {
            var situacaoAluno = avaliacao.Avalia(7, 7, 18, 64);
            Assert.AreEqual("Reprovado por Falta.", situacaoAluno);    
        }

        [TestMethod]
        public void TestCenario6()
        {
            var situacaoAluno = avaliacao.Avalia(1.5, 3, 10, 128);
            Assert.AreEqual("Reprovado por Média.", situacaoAluno);
        }

        [TestMethod]
        public void TestCenario7()
        {
            var situacaoAluno = avaliacao.Avalia(10, 1.5, 12, 64);
            Assert.AreEqual("Prova Extra.", situacaoAluno);
        }

        [TestMethod]
        public void TestCenario8()
        {
            var situacaoAluno = avaliacao.Avalia(8, 6, 4, 32);
            Assert.AreEqual("Aprovado.", situacaoAluno);
        }
    }
}
