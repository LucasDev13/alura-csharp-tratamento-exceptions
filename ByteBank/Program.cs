using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo();
        }

        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            if (resultado == -1)
            {
                Console.WriteLine("Não é possível fazer divisão por 0");
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            
        }

        private static int Dividir(int numero, int divisor)
        {
            if (divisor == 0)
            {
                return -1;
            }
            else
            {
                return numero / divisor;
            }
        }
    }
}
