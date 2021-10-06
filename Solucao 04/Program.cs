using System;
using System.Globalization;

namespace Solucao_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double sp = 67.83643, rj= 36.67866, mg = 29.22988, es = 27.16548 ,Outros = 19.84953;

                         double total = sp + rj + mg + es + Outros;

            double resultadoSp = (67.83643 * 100) / total;
            double resultadoRj = (36.67866 * 100) / total;
            double resultadoMg = (29.22988 * 100) / total;
            double resultadoEs = (27.16548 * 100) / total;
            double resultadoOutros = (19.84953 * 100) / total;

            Console.WriteLine("Valor Total mensal da Distribuidora {0}", total.ToString("###.###.##") ,CultureInfo.InvariantCulture );

            Console.WriteLine();
            Console.WriteLine("SP – " + resultadoSp.ToString("F1")+"%");
            Console.WriteLine("RJ – " + resultadoRj.ToString("F1") + "%");
            Console.WriteLine("MG – " + resultadoMg.ToString("F1") + "%");
            Console.WriteLine("ES – " + resultadoEs.ToString("F1") + "%");
            Console.WriteLine("Outros – " + resultadoOutros.ToString("F1") + "%");

            Console.WriteLine();


            double resultadototal = resultadoSp + resultadoRj + resultadoMg + resultadoEs + resultadoOutros;

            Console.WriteLine(resultadototal + "%");

            //4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

            //SP – R$67.836,43
            //RJ – R$36.678,66
            //MG – R$29.229,88
            //ES – R$27.165,48
            //Outros – R$19.849,53

            //Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.


        }
    }
}
