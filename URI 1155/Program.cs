using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1155
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
             * S = 1 + 1/2 + 1/3 + … + 1/100
             * 
             * Entrada
             * Não há nenhuma entrada neste problema.
             * 
             * Saída
             * A saída contém um valor correspondente ao valor de S.
             * O valor deve ser impresso com dois dígitos após o ponto decimal.*/

            double S = 1;

            for (int i = 2; i <= 100; i++)
            {
                S += (double) 1 / i;
            }

            Console.WriteLine(S.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
