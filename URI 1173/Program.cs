using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1173
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Leia um valor e faça um programa que coloque o valor lido na primeira posição de um vetor N[10].
             * Em cada posição subsequente, coloque o dobro do valor da posição anterior. Por exemplo, se o valor
             * lido for 1, os valores do vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em seguida.
             * 
             * Entrada
             * A entrada contém um valor inteiro (V<=50).
             * 
             * Saída
             * Para cada posição do vetor, escreva "N[i] = X", onde i é a posição do vetor e X é o valor armazenado
             * na posição i. O primeiro número do vetor N (N[0]) irá receber o valor de V.*/

            int V = int.Parse(Console.ReadLine());

            int[] N = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    N[i] = V;
                }
                else
                {
                    N[i] = N[i - 1] * 2;
                }

                Console.WriteLine("N[" + i + "] = " + N[i]);

            }
        }
    }
}
