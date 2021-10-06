using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Solucao03
{
    class Program
    {
        //Nao consegui  pensar em um raciocínio lógico para completar o exercicio
        static void Main(string[] args)
        {
            string path = @"D:\dados.json";
           
           

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                  
                    Console.WriteLine(line);


                }
            }

        }


    }
}
