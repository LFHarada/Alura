using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente lucasfigueira = new ContaCorrente();
            lucasfigueira.titular = "Lucas Figueira";
            lucasfigueira.agencia = 0001;
            lucasfigueira.numerodaconta = 123987456;
            lucasfigueira.saldo = 1589.95;
            lucasfigueira.cpf = 07199220626;

            ContaCorrente lucasharada = new ContaCorrente();
            lucasharada.titular = "Lucas Harada";
            lucasharada.agencia = 0001;
            lucasharada.numerodaconta = 123987456;
            lucasharada.saldo = 1589.95;
            lucasharada.cpf = 07199220626;

            Console.WriteLine("Titular: " + lucasfigueira.titular);
            Console.WriteLine("Agência: " + lucasfigueira.agencia);
            Console.WriteLine("Número da Conta: " + lucasfigueira.numerodaconta);
            Console.WriteLine("Saldo: " + lucasfigueira.saldo);
            Console.WriteLine("CPF: " + lucasfigueira.cpf);

            Console.WriteLine();

            Console.WriteLine("Titular: " + lucasharada.titular);
            Console.WriteLine("Agência: " + lucasharada.agencia);
            Console.WriteLine("Número da Conta: " + lucasharada.numerodaconta);
            Console.WriteLine("Saldo: " + lucasharada.saldo);
            Console.WriteLine("CPF: " + lucasharada.cpf);

            Console.ReadLine();
        }
    }
}
