using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            
            //character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);
            
            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);
            
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            
            Console.WriteLine(titulo);
            // Parágrafos podem ser feitos assim
            string cursosProgramacao = 
            @" - .NET 
            - Java 
            - Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine(titulo);
            // Ou assim
            string cursosProgramacao2 = "\n- .NET\n- Java\n- Javascript";
            Console.WriteLine(cursosProgramacao2);
            
            Console.ReadLine();
        }
    }
}
