using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes
             * intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
             * nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
             * 
             * O símbolo ( representa "maior que". Por exemplo:
             * [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
             * (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000
             * 
             * Entrada
             * O arquivo de entrada contém um número com ponto flutuante qualquer.
             * 
             * Saída
             * A saída deve ser uma mensagem conforme exemplo abaixo*/

            double numeroEntrada;

            numeroEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numeroEntrada >= 0 && numeroEntrada <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            } else if (numeroEntrada > 25 && numeroEntrada <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            } else if (numeroEntrada > 50 && numeroEntrada <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            } else if (numeroEntrada > 75 && numeroEntrada <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            } else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
