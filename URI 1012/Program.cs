using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
             * Em seguida, calcule e mostre:
             * 
             * a) a área do triângulo retângulo que tem A por base e C por altura.
             * b) a área do círculo de raio C. (pi = 3.14159)
             * c) a área do trapézio que tem A e B por bases e C por altura.
             * d) a área do quadrado que tem lado B.
             * e) a área do retângulo que tem lados A e B.
             * 
             * Entrada
             * O arquivo de entrada contém três valores com um dígito após o ponto decimal.
             * 
             * Saída
             * O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das
             * áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor.
             * O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.*/

            double A, B, C;
            double triangulo, circulo, trapezio, quadrado, retangulo;
            double pi = 3.14159; //Pi declarado, porque o Math.PI apresenta um valor maior

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = (double) A * C / 2.00;
            circulo = pi * C * C;
            trapezio = (A + B) / 2.00 * C;
            quadrado = Math.Pow(B, 2.00);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
