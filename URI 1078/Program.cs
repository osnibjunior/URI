using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
             * 1 x N = N      2 x N = 2N        ...       10 x N = 10N
             * 
             * Entrada
             * A entrada contém um valor inteiro N (2 < N < 1000).
             * 
             * Saída
             * Imprima a tabuada de N, conforme o exemplo fornecido.*/

            int N, i = 1;

            N = int.Parse(Console.ReadLine());

            while (i < 11)
            {
                int valor = i * N;
                Console.WriteLine(i + " x " + N + " = " + valor);
                i++;
            }
        }
    }
}
