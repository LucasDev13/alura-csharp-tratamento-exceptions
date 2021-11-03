using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(0,0);
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Argumento com problema: {e.ParamName}");
                Console.WriteLine($"Ocorreu uma exceção do tipo {e.GetType()} - {e.Message}");
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
