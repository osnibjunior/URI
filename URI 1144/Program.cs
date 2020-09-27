using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1144
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa,
             * seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.
             * 
             * Entrada
             * O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).
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
                Console.Write(i + " ");
                m1++;
                m2++;
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
            }
        }
    }
}
