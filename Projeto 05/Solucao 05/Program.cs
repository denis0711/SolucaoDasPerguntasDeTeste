using System;
using System.Collections.Generic;
using System.Linq;

namespace Solucao_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string exemplo = Console.ReadLine();

            string textoInvertido = new string(exemplo.Reverse().ToArray());

            Console.WriteLine(textoInvertido);



        }
        //5) Escreva um programa que inverta os caracteres de um string.

        //IMPORTANTE:
        //a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
        //b) Evite usar funções prontas, como, por exemplo, reverse;
        //Obs: nao consegui sem usar o Reverse !!

    }
}
