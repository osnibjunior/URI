using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace URI_1172
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Faça um programa que leia um vetor X[10]. Substitua a seguir,
             * todos os valores nulos e negativos do vetor X por 1. Em seguida mostre o vetor X.
             * 
             * Entrada
             * A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.
             * 
             * Saída
             * Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o
             * valor armazenado naquela posição.*/

            int[] vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] <= 0)
                {
                    vet[i] = 1;
                }

                Console.WriteLine("X[" + i + "] = " + vet[i]);
            }
        }
    }
}
