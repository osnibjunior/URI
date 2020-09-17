using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
             * Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês,
             * com duas casas decimais.
             * 
             * Entrada
             * O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double)
             * com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor,
             * respectivamente.
             * 
             * Saída
             * Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.*/

            string vendedor;
            double salario, vendasEfetuadas, comissao;

            vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = salario + (vendasEfetuadas * 15.0) / 100.0;

            Console.WriteLine("TOTAL = R$ " + comissao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
