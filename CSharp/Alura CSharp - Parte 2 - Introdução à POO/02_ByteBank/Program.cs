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
            lucasfigueira.saldo = 2000;
            lucasfigueira.cpf = 07199220626;

            ContaCorrente lucasharada = new ContaCorrente();
            lucasharada.titular = "Lucas Harada";
            lucasharada.agencia = 0001;
            lucasharada.numerodaconta = 123987456;
            lucasharada.saldo = 1589.95;
            lucasharada.cpf = 07199220626;

            Console.WriteLine("Saldo 1ª Conta Corrente: " + lucasfigueira.saldo);
            Console.WriteLine("Saldo 2ª Conta Corrente: " + lucasharada.saldo);

            double saldoambas = lucasharada.saldo + lucasfigueira.saldo;

            Console.WriteLine("Saldo em ambas Contas Correntes: " + saldoambas);

            Console.ReadLine();
        }
    }
}
