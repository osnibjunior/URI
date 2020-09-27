using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão
             * dele por 5 for igual a 2 ou igual a 3.
             * 
             * Entrada
             * O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.
             * 
             * Saída
             * Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.*/

            int X, Y;
            int maior, menor, total;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                maior = X;
                menor = Y;
            } else
            {
                maior = Y;
                menor = X;
            }

            total = maior - menor - 1;

            for (int i = 0; i < total; i++)
            {
                menor++;
                if (menor % 5 == 2 || menor % 5 == 3)
                {
                    Console.WriteLine(menor);
                }
            }
        }
    }
}
