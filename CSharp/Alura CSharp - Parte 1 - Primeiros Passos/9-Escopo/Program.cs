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

            string mensagemidade;
            string mensagemacompanhado;



            if (maiordeidade == true)
            {
                mensagemidade = "João é maior de idade.";
            }
            else
            {
                mensagemidade = "João não é maior de idade.";
            }
            


            if (acompanhado == true)
            {
                mensagemacompanhado = "João está acompanhado.";
            }
            else
            {
                mensagemacompanhado = "João não está acompanhado.";
            }



            if (maiordeidade == true && acompanhado == true)
            {

                Console.WriteLine(mensagemidade);
                Console.WriteLine(mensagemacompanhado);
                Console.WriteLine("Pode entrar.");
            }
            else if (maiordeidade == false && acompanhado == true)
            {
                Console.WriteLine(mensagemidade);
                Console.WriteLine(mensagemacompanhado);
                Console.WriteLine("Não pode entrar");
            }
            else if (maiordeidade == true && acompanhado == false)
            {
                Console.WriteLine(mensagemidade);
                Console.WriteLine(mensagemacompanhado);
                Console.WriteLine("Não pode entrar");
            }
            else
            {
                Console.WriteLine(mensagemidade);
                Console.WriteLine(mensagemacompanhado);
                Console.WriteLine("Não pode entrar");
            }



            // alternativa melhor
            if (maiordeidade == true && acompanhado == true)
            {

                Console.WriteLine(mensagemidade);
                Console.WriteLine(mensagemacompanhado);
                Console.WriteLine("Pode entrar.");
            }
            else if (maiordeidade == false || acompanhado == false || maiordeidade == false && acompanhado == false)
            {
                Console.WriteLine(mensagemidade);
                Console.WriteLine(mensagemacompanhado);
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
            
        }
    }
}