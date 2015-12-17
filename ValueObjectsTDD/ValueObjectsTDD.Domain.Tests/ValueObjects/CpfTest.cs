using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueObjectsTDD.ValueObjects;

namespace ValueObjectsTDD.Domain.Tests.ValueObjects
{
    [TestClass]
    public class CpfTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCpfNulo()
        {
            var cpf = new Cpf(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCpfVazio()
        {
            var cep = new Cpf("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCpfComEspacoEmBranco()
        {
            var cpf = new Cpf(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCpfInvalido()
        {
            var cpf = new Cpf("abc");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCpfComValorInvalido()
        {
            var cpf = new Cpf("1234");
        }

        [TestMethod]
        public void RetornarCpfLimpo()
        {
            var cpf = new Cpf("891.658.576-74");
            Assert.AreEqual("89165857674", cpf.GetCpfCompleto());
        }
    }
}