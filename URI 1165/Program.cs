using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1165
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo.
             * Por exemplo, o número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.
             * 
             * Entrada
             * A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100),
             * indicando o número de casos de teste da entrada. Cada uma das N linhas seguintes contém um valor inteiro X (1 < X ≤ 10^7),
             * que pode ser ou não, um número primo.
             * 
             * Saída
             * Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”,
             * de acordo com a especificação fornecida.*/

            int N = int.Parse(Console.ReadLine());
            int X;
            int cont;

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                cont = 0;
                for (int c = 2; c < X; c++)
                {
                    if (X % c == 0 && cont == 0)
                    {
                        Console.WriteLine(X + " nao eh primo");
                        cont++;
                    }
                }

                if (cont == 0)
                {
                    Console.WriteLine(X + " eh primo");
                }

            }
        }
    }
}
