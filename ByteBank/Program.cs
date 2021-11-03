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
                ContaCorrente contaCorrente = new ContaCorrente(10,2);
                contaCorrente.Depositar(50);
                contaCorrente.Sacar(500);
                
            }
            catch (ArgumentException e)
            {
                if(e.ParamName == "numero")
                {

                }

                Console.WriteLine($"Argumento com problema: {e.ParamName}");
                Console.WriteLine($"Ocorreu uma exceção do tipo {e.GetType()} - {e.Message}");

            }catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Execeção do tipo SaldoInsuficienteException");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
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
