using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Caracteres_e_Textos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "\nAlura Cursos de tecnologia " + 2021;
            string cursosProgramacao = "- C#\n- Python\n- .NET\n- JavaScript\n- Java\n";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }

    public class Program
    {

        public static void main(string[] args)
        {

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = 65;                    // Não Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);         // Compila!
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);
        }
    }
}
