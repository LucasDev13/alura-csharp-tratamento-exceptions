﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Arquivo
{
    public class LeitorDeArquivo
    {

        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            //lançando a exceção 
            throw new FileNotFoundException();
            Console.WriteLine($"Abrindo o arquivo: {arquivo}");
        }

        public string LerproximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            throw new IOException();

            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
