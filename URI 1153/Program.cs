using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1153
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
             * 
             * Entrada
             * A entrada contém um valor inteiro N (0 < N < 13).
             * 
             * Saída
             * A saída contém um valor inteiro, correspondente ao fatorial de N.*/

            int N = int.Parse(Console.ReadLine());
            long fatorial;
            int cont;

            fatorial = N;
            cont = N;
            for (int i = 1; i < cont; i++)
            {
                N--;
                fatorial *= N;
            }

            Console.WriteLine(fatorial);
        }
    }
}
