using System;
using ValueObjectsTDD.Enums;
using ValueObjectsTDD.Helpers;

namespace ValueObjectsTDD.ValueObjects
{
    public class Endereco
    {
        public const int LogradouroMaxLength = 150;
        public virtual string Logradouro { get; private set; }

        public const int ComplementoMaxLength = 150;
        public virtual string Complemento { get; private set; }

        public const int NumeroMaxLength = 50;
        public virtual string Numero { get; private set; }

        public const int BairroMaxLength = 150;
        public virtual string Bairro { get; private set; }

        public const int CidadeMaxLength = 150;
        public virtual string Cidade { get; private set; }

        public virtual Uf? Uf { get; private set; }

        public virtual Cep Cep { get; private set; }

        public Endereco(string logradouro, string complemento, string numero, string bairro,
            string cidade, Uf? uf, Cep cep)
        {
            SetCep(cep);
            SetBairro(bairro);
            SetCidade(cidade);
            SetComplemento(complemento);
            SetLogradouro(logradouro);
            SetNumero(numero);
            SetUf(uf);
        }

        public void SetCep(Cep cep)
        {
            Cep.NotNullOrEmpty(cep);
            Cep = cep;
        }

        public void SetComplemento(string complemento)
        {
            if (string.IsNullOrEmpty(complemento))
                complemento = "";
            Guard.StringLength("Complemento", complemento, ComplementoMaxLength);
            Complemento = TextoHelper.ToTitleCase(complemento);
        }

        public void SetLogradouro(string logradouro)
        {
            Guard.ForNullOrEmptyDefaultMessage(logradouro, "Endereço");
            Guard.StringLength("Logradouro", logradouro, LogradouroMaxLength);
            Logradouro = TextoHelper.ToTitleCase(logradouro);
        }

        public void SetNumero(string numero)
        {
            Guard.ForNullOrEmptyDefaultMessage(numero, "Número");
            Guard.StringLength("Numero", numero, NumeroMaxLength);
            Numero = numero;
        }

        public void SetBairro(string bairro)
        {
            Guard.ForNullOrEmptyDefaultMessage(bairro, "Bairro");
            Guard.StringLength("Bairro", bairro, BairroMaxLength);
            Bairro = TextoHelper.ToTitleCase(bairro);
        }

        public void SetCidade(string cidade)
        {
            Guard.ForNullOrEmptyDefaultMessage(cidade, "Cidade");
            Guard.StringLength("Cidade", cidade, CidadeMaxLength);
            Cidade = TextoHelper.ToTitleCase(cidade);
        }

        public void SetUf(Uf? uf)
        {
            if (!uf.HasValue)
                throw new Exception("Estado é obrigatório");
            Uf = uf;
        }

        public override string ToString()
        {
            return Logradouro + ", " + Numero + " - " + Complemento + " <br /> " + Bairro + " - " + Cidade + "/" + Uf;
        }
    }
}
