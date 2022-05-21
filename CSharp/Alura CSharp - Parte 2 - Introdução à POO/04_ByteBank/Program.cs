using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
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

            Console.WriteLine("Saldo do Lucas: " + lucasfigueiraharada.saldo);
            bool resultadoSaque = lucasfigueiraharada.Sacar(100);
            
            Console.WriteLine("Saque bem sucedido? " + resultadoSaque);
            Console.WriteLine("Saldo do Lucas: " + lucasfigueiraharada.saldo);

            ContaCorrente alessandra = new ContaCorrente();
            alessandra.titular = "Alessandra Barbosa Figueira";
            alessandra.agencia = 0001;
            alessandra.numerodaconta = 54946848;
            alessandra.saldo = 20000;
            alessandra.cpf = 88099083687;

            bool resultadoTransferencia = alessandra.Transferir(400, lucasfigueiraharada);

            Console.WriteLine("Saldo do Lucas: " + lucasfigueiraharada.saldo);
            Console.WriteLine("Saldo da Alessandra: " + alessandra.saldo);
            Console.WriteLine("Transferência bem sucedida? " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
