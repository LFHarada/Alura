using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 5000.00;
            double fatorRendimento = 1.0045;

            for (int contadorAno = 1; contadorAno <= 10; contadorAno++);
            {   
                fatorRendimento += 0.0010;
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
            }

            Console.WriteLine("O tempo de investimento foi de ");
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.ReadLine();

        }
    }
}
