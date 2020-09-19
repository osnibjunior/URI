using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1157
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Ler um número inteiro N e calcular todos os seus divisores.
             * 
             * Entrada
             * O arquivo de entrada contém um valor inteiro.
             * 
             * Saída
             * Escreva todos os divisores positivos de N, um valor por linha.*/

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
