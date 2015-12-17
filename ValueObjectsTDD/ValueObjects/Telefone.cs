using ValueObjectsTDD.Helpers;

namespace ValueObjectsTDD.ValueObjects
{
    public class Telefone
    {
        public const int NumeroMaxLength = 20;
        public string Numero { get; private set; }

        public const int DddMaxLength = 3;
        public string Ddd { get; private set; }

        public Telefone(string ddd, string numero)
        {
            SetTelefone(numero);
            SetDdd(ddd);
        }

        private void SetTelefone(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                numero = "";
            else
                Guard.StringLength("Telefone", numero, NumeroMaxLength);
            Numero = numero;
        }

        private void SetDdd(string ddd)
        {
            if (string.IsNullOrEmpty(ddd))
                ddd = "";
            else
                Guard.StringLength("DDD", ddd, DddMaxLength);
            Ddd = ddd;
        }

        public string GetTelefoneCompleto()
        {
            return Ddd + Numero;
        }
    }
}
