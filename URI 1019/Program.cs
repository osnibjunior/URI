using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
             * e informe-o expresso no formato horas:minutos:segundos.
             * 
             * Entrada
             * O arquivo de entrada contém um valor inteiro N.
             * 
             * Saída
             * Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos,
             * conforme exemplo fornecido*/

            int N, horas, minutos, segundos, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
