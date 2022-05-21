using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            
            cliente1.nome = "Lucas Figueira Harada";
            cliente1.endereco = "Avenida ABC, 123, Centro, Monte Alegre de Minas, MG";
            cliente1.sexo = "Masculino";
            cliente1.datanasc = "11/11/2001";
            cliente1.cpf = "123.456.789-10";
            cliente1.rg = "MG-12.345.678";
            cliente1.profissao = "Full Stack Developer";
            
            conta1._titular = cliente1;
            conta1._agencia = 0001;
            conta1._conta = 987654;
            conta1._tipoconta = "Conta Corrente";
            
            conta1.Saldo = -500;
            
            Console.WriteLine(conta1._titular.nome);
            Console.WriteLine(conta1.Saldo);
            
            Console.ReadLine();
        }
    }
}
