using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos2
{
    class Program
    {
        static void Main(string[] args)
        {

            char letra = 'a';
            Console.WriteLine(letra);
            
            // Não Compila!
            char valor = 65;  
            Console.WriteLine(valor);
            
            // Compila!
            valor = (char)(valor + 1); 
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

        }
    }
}
