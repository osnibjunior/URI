using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
             * Perimetro = XX.X
             * 
             * Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
             * Area = XX.X
             * 
             * Entrada
             * A entrada contém três valores reais.
             * 
             * Saída
             * O resultado deve ser apresentado com uma casa decimal.*/

            string[] entrada = Console.ReadLine().Split(' ');

            double A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (A < B + C && A > Math.Abs(B - C))
            {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));

            } else
            {
                double area = (A + B) / 2.0 * C;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
