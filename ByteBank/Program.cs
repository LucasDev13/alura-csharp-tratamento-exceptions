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
            }catch(NullReferenceException erro)
            {
                Console.WriteLine("Aconteceu um erro - " + erro.Message);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                //trecho de código que pode dar uma exception
                //try = tente executar esse trecho que código.
                int resultado = Dividir(10, divisor);//aqui vai parar a execução do código
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch(DivideByZeroException erro) {
                //catch = vai pegar as exceções
                //vem para o bloco catch para mostrar a exception
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possível fazer divisão por 0" + erro.Message);
            }            
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
