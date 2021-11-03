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

        public SaldoInsuficienteException(double saldo, double valorSaldo) 
            : this($"Tentativa de saque no valor de {valorSaldo} em uma conta com saldo de {saldo}")
        {
            Saldo = saldo;
            ValorSaldo = valorSaldo;
        }

        public SaldoInsuficienteException(string message): base(message)
        {

        }
    }
}
