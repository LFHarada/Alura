using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente lucasfigueiraharada = new ContaCorrente();
            lucasfigueiraharada.titular = "Lucas Figueira Harada";
            lucasfigueiraharada.agencia = 0001;
            lucasfigueiraharada.numerodaconta = 123987456;
            lucasfigueiraharada.saldo = 2000;
            lucasfigueiraharada.cpf = 07199220626;

            Console.WriteLine(lucasfigueiraharada.saldo);
            bool resultadoSaque = lucasfigueiraharada.Sacar(150);
            Console.WriteLine(lucasfigueiraharada.saldo);
            Console.WriteLine(resultadoSaque);

            Console.ReadLine();
        }
    }
}
