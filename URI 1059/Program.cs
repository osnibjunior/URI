using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1059
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que mostre os números pares entre 1 e 100, inclusive.
             * 
             * Entrada
             * Neste problema extremamente simples de repetição não há entrada.
             * 
             * Saída
             * Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada linha.*/

            int numPar = 1;

            while (numPar <= 100)
            {
                if (numPar % 2 == 0)
                {
                    Console.WriteLine(numPar);
                }
                numPar++;
            }
        }
    }
}