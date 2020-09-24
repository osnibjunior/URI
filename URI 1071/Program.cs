using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
             * 
             * Entrada
             * O arquivo de entrada contém dois valores inteiros.
             * 
             * Saída
             * O programa deve imprimir um valor inteiro.
             * Este valor é a soma dos valores ímpares que estão entre os valores fornecidos na entrada que deverá caber em um inteiro.*/

            int X, Y, min, max, soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                min = X;
                max = Y;
            } else
            {
                min = Y;
                max = X;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
