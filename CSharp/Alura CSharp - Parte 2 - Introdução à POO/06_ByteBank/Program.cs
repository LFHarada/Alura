using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente lucas = new Cliente();
            lucas.nome = "Lucas Figueira Harada";
            lucas.cpf = "071.992.206-26";
            lucas.profissao = "Dev Full Stack";

            ContaCorrente contalucas = new ContaCorrente();
            contalucas.titular = lucas.nome;
            //contalucas.saldo = 4800;
            contalucas.agencia = 0001;
            contalucas.numero = 123654789;
            contalucas.DefinirSaldo(-10);

            Console.WriteLine(ContaCorrente.ObterSaldo());

            Console.ReadLine();
        }
    }
}
