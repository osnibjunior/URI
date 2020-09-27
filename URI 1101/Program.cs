using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero).
             * Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).
             * 
             * Entrada
             * O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.
             * 
             * Saída
             * Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.*/

            string[] valores = Console.ReadLine().Split(' ');

            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            int maior, menor, soma;

            while (M > 0 && N > 0)
            {
                soma = 0;
                maior = 0;
                menor = 0;

                if (M >= N)
                {
                    maior = M;
                    menor = N;
                } else
                {
                    maior = N;
                    menor = M;
                }

                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }

                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');

                M = int.Parse(valores[0]);
                N = int.Parse(valores[1]);

            }

        }
    }
}
