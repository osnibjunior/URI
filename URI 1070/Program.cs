using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos
             * a partir de X, um valor por linha, inclusive o X ser for o caso.
             * 
             * Entrada
             * A entrada será um valor inteiro positivo.
             * 
             * Saída
             * A saída será uma sequência de seis números ímpares.*/

            int x = int.Parse(Console.ReadLine());
            int contagem = x;

            if (x % 2 == 0)
            {
                contagem++;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
            } else
            {
                Console.WriteLine(x);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
            }
        }
    }
}
