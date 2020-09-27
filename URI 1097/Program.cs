using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1097
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
             * I=1 J=7
             * I=1 J=6
             * I=1 J=5
             * I=3 J=9
             * I=3 J=8
             * I=3 J=7
             * ...
             * I=9 J=15
             * I=9 J=14
             * I=9 J=13*/
            
            int I, J;
            I = 1;
            J = 7;

            do
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I.ToString() + " J=" + J.ToString());
                    J--;
                }
                I += 2;
                J += 5;
            } while (J <= 15);
        }
    }
}
