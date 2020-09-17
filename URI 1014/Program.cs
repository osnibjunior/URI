using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o
             * total de combustível gasto (em litros).
             * 
             * Entrada
             * O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km),
             * e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
             * 
             * Saída
             * Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".*/

            int X;
            double Y, consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture)+" km/l");}
    }
}
