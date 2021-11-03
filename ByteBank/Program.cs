using ByteBank.Excecoes;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conta1 = new ContaCorrente(1010, 2587);
                var conta2 = new ContaCorrente(4587, 25463);

                //conta1.Transferir(10000, conta2);
                conta2.Sacar(10000);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("innnerException");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
            //Metodo();
        }

        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);//aqui vai parar a execução do código
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
                       
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Execeção com número= {numero} e divisor= {divisor}");
                throw;//finaliza a execução e retorna a exceção.
            }
        }
    }
}
