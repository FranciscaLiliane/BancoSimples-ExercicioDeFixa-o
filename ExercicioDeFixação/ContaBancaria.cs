using System;
using System.Globalization;

namespace ExercicioDeFixação
{
    class ContaBancaria
    {
        private string _nome;
        public int Numero { get; private set; }
        public double Valor { get; private set; }

        public ContaBancaria(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }
        public ContaBancaria(string nome, int numero, double valor) : this(nome, numero)
        {
            Valor = valor;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public void deposito(double valor)
        {
            Valor += valor;
        }
        public void saque(double valor)
        {
            Valor -= valor;
            Valor -= 5.0;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
