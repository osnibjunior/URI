using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos).\
             * A seguir, mostre a quantidade de valores positivos digitados.
             * 
             * Entrada
             * Seis valores, negativos e/ou positivos.
             * 
             * Saída
             * Imprima uma mensagem dizendo quantos valores positivos foram lidos.*/

            double numOne = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double numTwo = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double numThree = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double numFour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double numFive = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double numSix = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            int valorPositivo = 0;

            if (numOne > 0.00)
            {
                valorPositivo += 1;
            }

            if (numTwo > 0.00)
            {
                valorPositivo += 1;
            }

            if (numThree > 0.00)
            {
                valorPositivo += 1;
            }

            if (numFour > 0.00)
            {
                valorPositivo += 1;
            }

            if (numFive > 0.00)
            {
                valorPositivo += 1;
            }

            if (numSix > 0.00)
            {
                valorPositivo += 1;
            }

            Console.WriteLine(valorPositivo + " valores positivos");
        }
    }
}
