﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool maiordeidade = idadeJoao >= 18;
            bool acompanhado = quantidadePessoas >= 2;

            if (maiordeidade == true && acompanhado == true)
            {
                Console.WriteLine("Authorized Access");
            }

            else
            {
                Console.WriteLine("Access Denied");
            }

            Console.ReadLine(); 
        }
    }
}