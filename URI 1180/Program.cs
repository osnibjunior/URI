using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1180
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia um valor N. Este N será o tamanho de um vetor X[N]. A seguir, leia cada um dos valores de X,
             * encontre o menor elemento deste vetor e a sua posição dentro do vetor, mostrando esta informação.
             * 
             * Entrada
             * A primeira linha de entrada contem um único inteiro N (1 < N < 1000), indicando o número de elementos que deverão ser
             * lidos em seguida para o vetor X[N] de inteiros. A segunda linha contém cada um dos N valores, separados por um espaço.
             * 
             * Saída
             * A primeira linha apresenta a mensagem “Menor valor:” seguida de um espaço e do menor valor lido na entrada.
             * A segunda linha apresenta a mensagem “Posicao:” seguido de um espaço e da posição do vetor na qual se encontra o menor valor lido,
             * lembrando que o vetor inicia na posição zero.*/

            int N = int.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');

            int[] X = new int[N];

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(vet[i]);
            }

            int menorValor = X[0];
            int posicao = 0;

            for (int i = 0; i < N; i++)
            {
                if (X[i] < menorValor)
                {
                    menorValor = X[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor: " + menorValor);
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}
