﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Excecoes
{
    public class SaldoInsuficienteException : Exception
    {

        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string message): base(message)
        {

        }
    }
}
