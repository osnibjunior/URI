﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1098
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
             * I=0 J=1
             * I=0 J=2
             * I=0 J=3
             * I=0.2 J=1.2
             * I=0.2 J=2.2
             * I=0.2 J=3.2
             * .....
             * I=2 J=?
             * I=2 J=?
             * I=2 J=?*/
             
            double I = 0.0;

            while (I <= 2.0)
            {
                double J = I + 1.0;
                if (I == 0.0 || I == 1.0)
                {
                    for (int e = 0; e < 3; e++)
                    {
                        Console.WriteLine("I=" + I.ToString(CultureInfo.InvariantCulture) + " J=" + J.ToString(CultureInfo.InvariantCulture));
                        J++;
                    }
                } else {
                    for (int e = 0; e < 3; e++)
                    {
                        if (I > 1.9) { //Não tenho orgulho nenhum desse if criado. Infelizmente foi uma gambiarra para não desfigurar todo o projeto!
                            Console.WriteLine("I=2 J=" + J.ToString(CultureInfo.InvariantCulture));
                            J++;
                        } else {
                            Console.WriteLine("I=" + I.ToString("F1", CultureInfo.InvariantCulture) + " J=" + J.ToString("F1", CultureInfo.InvariantCulture));
                            J++;
                        }
                    }
                }
                I += 0.2;
            }
        }
    }
}