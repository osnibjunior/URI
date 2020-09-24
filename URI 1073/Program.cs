using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N,
             * inclusive N, se for o caso.
             * 
             * Entrada
             * A entrada contém um valor inteiro N (5 < N < 2000).
             * 
             * Saída
             * Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.
             * 
             * Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés
             * de 1000000 o que ocasionará resposta errada. Neste caso, configure a precisão
             * adequadamente para que isso não ocorra.*/

            int N = int.Parse(Console.ReadLine());
            int numerador = 2;
            
            while (N >= numerador)
            {
                Console.WriteLine(numerador + "^2 = " + Math.Pow(numerador, 2));
                numerador += 2;
            }
        }
    }
}
