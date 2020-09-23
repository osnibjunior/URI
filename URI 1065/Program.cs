using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados
             * são pares e mostre esta informação.
             * 
             * Entrada
             * O arquivo de entrada contém 5 valores inteiros quaisquer.
             * 
             * Saída
             * Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de
             * valores pares lidos.*/

            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int numFive = int.Parse(Console.ReadLine());
            int valorInteiro = 0;

            if (numOne % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (numTwo % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (numThree % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (numFour % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (numFive % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            Console.WriteLine(valorInteiro + " valores pares");
        }
    }
}
