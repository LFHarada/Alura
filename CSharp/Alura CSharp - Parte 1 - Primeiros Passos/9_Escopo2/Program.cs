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
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 600.00;
            int contadorMes = 1;

            while (contadorMes <= 36)
            {
                // 0.36% = 0.0036
                valorInvestido = 600 + valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);

                // contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;
            }
            Console.ReadLine();

        }
    }
}