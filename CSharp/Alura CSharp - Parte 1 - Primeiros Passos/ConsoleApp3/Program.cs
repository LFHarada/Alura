using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            bool maiordeidade = idadeJoao >= 18;

            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;
            
            if (maiordeidade == true && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }

            else
            {
                Console.WriteLine("Não pode entrar");
            }
            Console.ReadLine();

        }
    }
}