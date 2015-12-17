using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueObjectsTDD.Enums;
using ValueObjectsTDD.Helpers;
using ValueObjectsTDD.ValueObjects;

namespace ValueObjectsTDD.Domain.Tests.ValueObjects
{
    [TestClass]
    public class EnderecoTest
    {
        //Logradouro
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirLogradouroNulo()
        {
            var endereco = new Endereco(null, "Test", "123", "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirLogradouroVazio()
        {
            var endereco = new Endereco("", "Test", "123", "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirLogradouroComTamanhoInvalido()
        {
            var logradouro = TextoHelper.GetRandomText(Endereco.LogradouroMaxLength + 1);
            var endereco = new Endereco(logradouro, "Test", "123", "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        //Complemento
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirComplementoComTamanhoInvalido()
        {
            var complemento = TextoHelper.GetRandomText(Endereco.ComplementoMaxLength + 1);
            var endereco = new Endereco("Avenida Paulista", complemento, "123", "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        //Numero
        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void NaoPermitirNumeroNulo()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", null, "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirNumeroVazio()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "", "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirNumeroComTamanhoInvalido()
        {
            var numero = TextoHelper.GetRandomText(Endereco.NumeroMaxLength + 1);
            var endereco = new Endereco("Avenida Paulista", "Test", numero, "Centro", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        //Bairro
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirBairroNulo()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "123", null, "São Paulo", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirBairroVazio()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "123", "", "São Paulo", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirBairroComTamanhoInvalido()
        {
            var bairro = TextoHelper.GetRandomText(Endereco.BairroMaxLength + 1);
            var endereco = new Endereco("Avenida Paulista", "Test", "123", bairro, "São Paulo", Uf.SP, new Cep("05873220"));
        }

        //Cidade
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCidadeNula()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "123", "Centro", null, Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCidadeVazio()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "123", "Centro", "", Uf.SP, new Cep("05873220"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCidadeComTamanhoInvalido()
        {
            var cidade = TextoHelper.GetRandomText(Endereco.BairroMaxLength + 1);
            var endereco = new Endereco("Avenida Paulista", "Test", "123", "Centro", cidade, Uf.SP, new Cep("05873220"));
        }

        //Uf
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirUfNulo()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "123", "Centro", "São Paulo", null, new Cep("05873220"));
        }

        //Cep
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoPermitirCepNulo()
        {
            var endereco = new Endereco("Avenida Paulista", "Test", "123", "Centro", "São Paulo", Uf.SP, null);
        }
    }
}