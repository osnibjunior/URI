using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
             * Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
             * Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro
             * valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
             * 
             * Entrada
             * O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém
             * um caso de teste com três valores com uma casa decimal cada valor.
             * 
             * Saída
             * Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.*/

            int N = int.Parse(Console.ReadLine());
            float v1, v2, v3;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                v1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
                v2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
                v3 = float.Parse(vet[2], CultureInfo.InvariantCulture);

                float m1 = (v1 * 2) / 10;
                float m2 = (v2 * 3) / 10;
                float m3 = (v3 * 5) / 10;

                float mediaFinal = m1 + m2 + m3;

                Console.WriteLine(mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
