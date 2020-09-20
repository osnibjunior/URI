using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
             * A seguir, calcule e mostre o valor da conta a pagar.
             * 
             * CÓDIGO   ESPECIFICAÇÃO       PREÇO
             * 1        CACHORRO QUENTE     R$ 4,00
             * 2        X-SALADA            R$ 4,50
             * 3        X-BACON             R$ 5,00
             * 4        TORRADA SIMPLES     R$ 2,00
             * 5        REFRIGERANTE        R$ 1,50
             * 
             * Entrada
             * O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
             * 
             * Saída
             * O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.*/

            string[] vet = Console.ReadLine().Split(' ');

            string item = vet[0];
            int quantidade = int.Parse(vet[1]);

            if (item == "1")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "2")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "3")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 5.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "4")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 2.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "5")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
