using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1151
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci.
             * Nessa sequência, cada número, depois dos 2 primeiros, é igual à soma dos 2 anteriores.
             * Escreva um algoritmo que leia um inteiro N (N < 46) e mostre os N primeiros números dessa série.
             * 
             * Entrada
             * O arquivo de entrada contém um valor inteiro N (0 < N < 46).
             * 
             * Saída
             * Os valores devem ser mostrados na mesma linha, separados por um espaço em branco.
             * Não deve haver espaço após o último valor.*/

            int N = int.Parse(Console.ReadLine());

            int anterior = 0;
            int atual = 0;
            int proximo = 1;

            for (int i = 0; i < N; i++)
            {

                if (N == 1) //Evitando troll, valido se o N é igual a 1 para só imprimir o zero
                {
                    Console.Write(atual);
                }
                else if (i < 1) //Imprimo o número zero e o primeiro número 1!
                {
                    atual = i;
                    Console.Write(atual + " ");
                    atual = proximo;
                    Console.Write(atual);
                    anterior = atual;
                    i++;
                }
                else //imprimo todo o restante de fibonacci
                {
                    atual = proximo;
                    Console.Write(" " + atual);

                    proximo = atual + anterior;
                    anterior = atual;

                }
            }
            Console.WriteLine();
        }
    }
}
