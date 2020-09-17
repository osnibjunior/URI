using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
             * o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
             * 
             * Entrada
             * O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros
             * e um valor com 2 casas decimais.
             * 
             * Saída
             * A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois
             * pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.*/

            int codigoUm, quantidadeUm;
            double valorUm;
            int codigoDois, quantidadeDois;
            double valorDois;
            double valorTotalPagar;

            string[] vetUm = Console.ReadLine().Split(' ');
            string[] vetDois = Console.ReadLine().Split(' ');

            codigoUm = int.Parse(vetUm[0]);
            quantidadeUm = int.Parse(vetUm[1]);
            valorUm = double.Parse(vetUm[2], CultureInfo.InvariantCulture);

            codigoDois = int.Parse(vetDois[0]);
            quantidadeDois = int.Parse(vetDois[1]);
            valorDois = double.Parse(vetDois[2], CultureInfo.InvariantCulture);

            valorTotalPagar = (quantidadeUm * valorUm) + (quantidadeDois * valorDois);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotalPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
