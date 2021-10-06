using System;

namespace Solucao_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num, count=0;
           
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero para ver se faz parte da sequencia !");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia Fibonacci =>");
            for(int i = 0; i< num; i++)
            {
                if(n == i)
                {
                    count += 1;
                }             
                Console.Write(" {0} ", Fibonacci(i));
                Console.WriteLine();
            }
            if(count == 1)
            {
                Console.WriteLine("o número informado pertence a sequência");
            }
            else
            {
                Console.WriteLine("o número informado não pertence a sequência");
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return (Fibonacci(n - 1) + Fibonacci (n - 2));
        }

        //2) Dado a sequência de Fibonacci,
        //onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
        //(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
        //escreva um programa na linguagem que desejar onde, informado um número,
        //ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado
        //pertence ou não a sequência.

        //IMPORTANTE:
        //Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
    }
}
