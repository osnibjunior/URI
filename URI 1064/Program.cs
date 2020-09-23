using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos.
             * Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados,
             * com um dígito após o ponto decimal.
             * 
             * Entrada
             * A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante.
             * Pelo menos um destes números será positivo.
             * 
             * Saída
             * O primeiro valor de saída é a quantidade de valores positivos.
             * A próxima linha deve mostrar a média dos valores positivos digitados.*/

            double numOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double numTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double numThree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double numFour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double numFive = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double numSix = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int contagem = 0;
            double somaValor = 0.00;

            if (numOne >= 0.00)
            {
                contagem += 1;
                somaValor += numOne;
            }

            if (numTwo >= 0.00)
            {
                contagem += 1;
                somaValor += numTwo;
            }

            if (numThree >= 0.00)
            {
                contagem += 1;
                somaValor += numThree;
            }

            if (numFour >= 0.00)
            {
                contagem += 1;
                somaValor += numFour;
            }

            if (numFive >= 0.00)
            {
                contagem += 1;
                somaValor += numFive;
            }

            if (numSix >= 0.00)
            {
                contagem += 1;
                somaValor += numSix;
            }

            double media = somaValor / contagem;

            Console.WriteLine(contagem + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
