using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1143
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um valor inteiro N (1 < N < 1000).
             * Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
             * 
             * Entrada
             * O arquivo de entrada contém um número inteiro positivo N.
             * 
             * Saída
             * Imprima a saída conforme o exemplo fornecido.*/

            int m1, m2;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                m1 = (int)Math.Pow(i, 2);
                m2 = m1 * i;
                Console.Write(i + " ");
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
                
            }
        }
    }
}
