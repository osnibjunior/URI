using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
             * 
             * Entrada
             * O arquivo de entrada contém 100 números inteiros, positivos e distintos.
             * 
             * Saída
             * Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.*/

            int numero, maior, posicao;

            maior = 0;
            posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
