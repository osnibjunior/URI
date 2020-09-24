using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha,
             * inclusive o X, se for o caso.
             * 
             * Entrada
             * O arquivo de entrada contém 1 valor inteiro qualquer.
             * 
             * Saída
             * Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.*/

            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
