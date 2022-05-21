using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // TIPOS DE VARIÁVEIS

            // bool
            // 1 byte
            // true ou false
            // É o mais simples tipo de dado. Pode conter apenas 2 valores - false ou true.
            // O tipo bool é importante entender para usar operadores lógicos como a instrução if

            // byte
            // 1 byte
            // O a 255

            // sbyte
            // 1 byte 
            // -128 a 127

            // short
            // 2 bytes 
            // -32768 a 32767

            // ushort 
            // 2 bytes 
            // O a 65535 

            // int
            // 4 bytes
            // -2147483648 a 2147483647
            // É uma abreviação para integer, um tipo de dado para armazenar números inteiros sem décimais.
            // Quando se trabalha com números, int é o tipo de dado mais usado.
            // Existem varios tipos de dados para armezenar um número inteiro em C#, cada tipo suporta armazenar um determinado tamanho.

            // uint
            // 4 bytes 
            // O to 4294967295

            // long 
            // 8 bytes 
            // -9223372036854775808Lto 9223372036854775807L

            // ulong
            // 8 bytes 
            // O a 18446744073709551615 

            // float
            // 4 bytes
            // Números até 1 O elevado a 38. Exemplo: 1O.Of, 12.5f 
            // É um tipo de dado usado para armazenar números reais que podem conter décimais.

            // double
            // 8 bytes 
            // Números até 1 O elevado a 308. Exemplo: 1 O.O, 12.33

            // decimal 
            // 16 bytes 
            // Números com até 28 casas decimais. Exemplo 10.991m, 33.333m

            // char
            // 2 bytes 
            // É usado para armazenar um único caracter, delimitado por aspas simples.

            // string
            // É usado para armazenar texto, em outras palavras, um número de chars.
            // Em C#, string são imutáveis, isso quer dizer que uma strings nunca alteram seu valor elas sempre são criadas.
            // Quando um metodo altera uma string, na verdade o valor da string não é alterado, uma nova string é retornada ao inves.
        }
    }
}
