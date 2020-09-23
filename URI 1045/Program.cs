using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados.
             * A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
             * se A ≥ B + C, apresente a mensagem: NAO FORMA TRIANGULO - OK
             * se A² = B² + C², apresente a mensagem: TRIANGULO RETANGULO - OK
             * se A² > B² + C², apresente a mensagem: TRIANGULO OBTUSANGULO - OK
             * se A² < B² + C², apresente a mensagem: TRIANGULO ACUTANGULO - OK
             * se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO - OK
             * se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES - OK
             * 
             * Entrada
             * A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).
             * 
             * Saída
             * Imprima todas as classificações do triângulo especificado na entrada.*/

            double A = 0, B = 0, C = 0;

            string[] vet = Console.ReadLine().Split(' ');

            float numOne = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float numTwo = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float numThree = float.Parse(vet[2], CultureInfo.InvariantCulture);

            if (Math.Max(numOne, numTwo) > numThree)
            {
                A = Math.Max(numOne, numTwo);
                if (A > Math.Max(numTwo, numThree))
                {
                    B = Math.Max(numTwo, numThree);
                    C = Math.Min(numTwo, numThree);
                }
                else
                {
                    B = Math.Max(numOne, numThree);
                    C = Math.Min(numOne, numThree);
                }
            }
            else
            {
                A = numThree;
                B = Math.Max(numOne, numTwo);
                C = Math.Min(numOne, numTwo);
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
