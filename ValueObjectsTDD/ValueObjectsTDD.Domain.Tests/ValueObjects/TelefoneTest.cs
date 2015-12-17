using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueObjectsTDD.Helpers;
using ValueObjectsTDD.ValueObjects;

namespace ValueObjectsTDD.Domain.Tests.ValueObjects
{
    [TestClass]
    public class TelefoneTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirDddTamanhoInvalido()
        {
            var ddd =TextoHelper.GetRandomText(Telefone.DddMaxLength + 1);
            var telefone = new Telefone(ddd, "123");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirNumeroTelefoneTamanhoInvalido()
        {
            var numero = TextoHelper.GetRandomText(Telefone.NumeroMaxLength + 1);
            var telefone = new Telefone("11", numero);
        }
    }
}