using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1095
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
             * 
             * I=1 J=60
             * I=4 J=55
             * I=7 J=50
             * ...
             * I=? J=0
             * 
             * Entrada
             * Não há nenhuma entrada neste problema.
             * 
             * Saída
             * Imprima a sequencia conforme exemplo abaixo*/

            int I, J;
            I = 1;
            J = 60;

            while (J >= 0)
            {
                Console.WriteLine("I=" + I+" J="+J);
                I += 3;
                J -= 5;
            }
        }
    }
}
