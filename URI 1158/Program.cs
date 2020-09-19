using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1158
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y.
             * Você deve apresentar a soma de Y ímpares consecutivos a partir de X inclusive o próprio X se ele for ímpar. Por exemplo:
             * 
             * para a entrada 4 5, a saída deve ser 45, que é equivalente à: 5 + 7 + 9 + 11 + 13
             * para a entrada 7 4, a saída deve ser 40, que é equivalente à: 7 + 9 + 11 + 13
             * 
             * Entrada
             * A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir.
             * Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.
             * 
             * Saída
             * Imprima a soma dos consecutivos números ímpares a partir do valor X.*/

            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                int X = 0;
                int Y = 0;
                int soma = 0;
                string[] valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);

                int impar = 0;
                while (impar != Y)
                {
                    if (X % 2 != 0)
                    {
                        soma += X;
                        X++;
                        impar++;
                    }
                    else
                    {
                        X++;
                    }
                }

                Console.WriteLine(soma);

            }
        }
    }
}
