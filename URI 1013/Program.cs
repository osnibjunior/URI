using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”.
             * Utilize a fórmula:
             * 
             * MaiorAB = (a+b+abs(a-b))/2
             * 
             * Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b).
             * Um segundo passo, portanto é necessário para chegar no resultado esperado.
             * 
             * Entrada
             * O arquivo de entrada contém três valores inteiros.
             * 
             * Saída
             * Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".*/

            int A, B, C, maior, maiorAB, maiorAC;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maiorAC = (A + C + Math.Abs(A - C)) / 2;

            maior = Math.Max(maiorAB, maiorAC);

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
