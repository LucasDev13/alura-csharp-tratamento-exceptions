using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(5,5);
                Metodo();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ocorreu uma exceção do tipo {e.GetType()} - {e.Message}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Não é possível divisão por zero {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Aconteceu um erro - {e.Message}");
                Console.WriteLine(e.StackTrace);
            }
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
