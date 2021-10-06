using System;

namespace Solucao01
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }
            Console.WriteLine(soma);

            //1) Observe o trecho de código abaixo:

            //int INDICE = 13, SOMA = 0, K = 0;

            //enquanto K<INDICE faça
            //{
            //    K = K + 1;
            //    SOMA = SOMA + K;
            //}

            //imprimir(SOMA);

            //Ao final do processamento, qual será o valor da variável SOMA ?

            //Resultado = 91

        }
    }
}
