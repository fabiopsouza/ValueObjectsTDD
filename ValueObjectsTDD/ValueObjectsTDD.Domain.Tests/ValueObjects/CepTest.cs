using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueObjectsTDD.ValueObjects;

namespace ValueObjectsTDD.Domain.Tests.ValueObjects
{
    [TestClass]
    public class CepTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCepNulo()
        {
            var cep = new Cep(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCepVazio()
        {
            var cep = new Cep("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCepComEspacoEmBranco()
        {
            var cep = new Cep(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCepInvalido()
        {
            var cep = new Cep("abc");
        }

        [TestMethod]
        public void RetornarCepFormatado()
        {
            var cep = new Cep("05873220");
            Assert.AreEqual("05873-220", cep.GetCepFormatado());
        }
    }
}