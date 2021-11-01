using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //pode dar uma exception.
                Metodo();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Aconteceu um erro - " + erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);//aqui vai parar a execução do código
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
                       
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
