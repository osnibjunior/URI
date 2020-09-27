using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral.
             * Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]).
             * Cada nota deve ser validada separadamente.
             * 
             * Entrada
             * A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.
             * 
             * Saída
             * Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
             * Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo.
             * O valor deve ser apresentado com duas casas após o ponto decimal.*/

            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = 0.0;
            double n1 = 0.0, n2 = 0.0;
            int controle = 0;

            while (controle < 2)
            {
                if (nota >= 0.0 && nota <= 10.0)
                {
                    if (controle == 0)
                    {
                        n1 = nota;
                        nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    } else
                    {
                        n2 = nota;
                    }
                    controle++;
                } else
                {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            media = (n1 + n2) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
