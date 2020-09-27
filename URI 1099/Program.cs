using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y.
             * Você deve apresentar a soma de todos os ímpares existentes entre X e Y.
             * 
             * Entrada
             * A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir.
             * Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.
             * 
             * Saída
             * Imprima a soma de todos valores ímpares entre X e Y.*/

            int N = int.Parse(Console.ReadLine());
            int X, Y, soma, maior, menor;
            string[] valor;

            for (int i = 1; i <= N; i++)
            {
                valor = Console.ReadLine().Split(' ');
                X = int.Parse(valor[0]);
                Y = int.Parse(valor[1]);

                if (X > Y)
                {
                    maior = X;
                    menor = Y;
                } else
                {
                    maior = Y;
                    menor = X;
                }

                soma = 0;
                menor += 1;
                for (int c = menor; c < maior; c++)
                {
                    if (c % 2 != 0)
                    {
                        soma += c;
                    }
                }

                Console.WriteLine(soma);

            }
        }
    }
}
