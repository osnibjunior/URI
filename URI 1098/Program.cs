using System;
using System.Globalization;

namespace URI_1098
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
             *
             * Entrada
             * Não há nenhuma entrada neste problema.
             *
             * Saída
             * Imprima a sequencia conforme exemplo abaixo.
             * 
             * I=0 J=1
             * I=0 J=2
             * I=0 J=3
             * I=0.2 J=1.2
             * I=0.2 J=2.2
             * I=0.2 J=3.2
             * .....
             * I=2 J=?
             * I=2 J=?
             * I=2 J=?*/

             float I = 0f;
             float J = 1f;

            for (int e = 0; e < 3; e++){
                Console.WriteLine("I="+I.ToString(CultureInfo.InvariantCulture)+" J="+J.ToString(CultureInfo.InvariantCulture));
                J++;
            }

        }
    }
}
