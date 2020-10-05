using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1156
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
             * S = 1 + 3/2 + 5/4 + 7/8 + ... + 39/?
             * 
             * Entrada
             * Não há nenhuma entrada neste problema.
             * 
             * Saída
             * A saída contém um valor correspondente ao valor de S.
             * O valor deve ser impresso com dois dígitos após o ponto decimal.*/

            double S = 0;
            double par = 1;
            double impar = 1;

            while (impar != 39)
            {
                S += impar / par;
                impar += 2;
                par += par;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
