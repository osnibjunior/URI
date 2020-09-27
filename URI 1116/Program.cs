using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1116
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
             * Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.
             * 
             * Entrada
             * A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.
             * 
             * Saída
             * Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.
             * 
             * Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)*/

            int N = int.Parse(Console.ReadLine());
            
            int cont = 0;

            double soma;

            while (cont < N)
            {
                string[] valores = Console.ReadLine().Split();

                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    soma = 0;
                    soma = (double)X / Y;
                    Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
                }
                cont++;
            }
        }
    }
}
