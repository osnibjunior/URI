using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
             * 
             * Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
             * Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
             * Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
             * 
             * Entrada
             * O arquivo de entrada contém um valor inteiro.
             * 
             * Saída
             * Imprima a saída conforme exemplo fornecido.*/

            int idade, quociente, resto;
            int ano = 365;
            int mes = 30;

            idade = int.Parse(Console.ReadLine());

            quociente = idade / ano;
            Console.WriteLine(quociente + " ano(s)");
            resto = idade % ano;

            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto = resto % mes;

            Console.WriteLine(resto + " dia(s)");
        }
    }
}
