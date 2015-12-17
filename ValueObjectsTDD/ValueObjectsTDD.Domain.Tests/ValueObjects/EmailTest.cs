using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueObjectsTDD.Helpers;
using ValueObjectsTDD.ValueObjects;

namespace ValueObjectsTDD.Domain.Tests.ValueObjects
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirEmailNulo()
        {
            var email = new Email(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirEmailVazio()
        {
            var email = new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirEmailComEspacoEmBranco()
        {
            var email = new Email(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirEmailInvalido()
        {
            var email = new Email("abc");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirEmailInvalidoComArroba()
        {
            var email = new Email("teste@email");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirEmailComTamanhoInvalido()
        {
            var endereco = TextoHelper.GetRandomText(Email.EnderecoMaxLength) + "@email.com";
            var email = new Email(endereco);
        }


    }
}