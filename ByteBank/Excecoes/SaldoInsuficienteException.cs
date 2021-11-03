using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Excecoes
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaldo { get; }

        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this($"Tentativa de saque no valor de {valorSaque} em uma conta com saldo de {saldo}")
        {
            Saldo = saldo;
            ValorSaldo = valorSaque;
        }

        public SaldoInsuficienteException(string message): base(message)
        {

        }
    }
}
