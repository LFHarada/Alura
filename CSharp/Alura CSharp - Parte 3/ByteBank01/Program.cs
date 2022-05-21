using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank01.Funcionarios;

namespace ByteBank01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-00"; 
            carlos.Salario = 2000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.ReadLine();
        }

    }
}
