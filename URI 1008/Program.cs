﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que
             * recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário,
             * com duas casas decimais.
             * 
             * Entrada
             * O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número,
             * quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.
             * 
             * Saída
             * Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e
             * depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.*/

            int codFuncionario, horasTrabalhadas;
            float valorHora, salario;

            codFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + codFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
