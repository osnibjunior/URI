using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
             * O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.
             * 
             * Entrada
             * A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.
             * 
             * Saída
             * A saída contém um valor correspondente à média de idade dos indivíduos.
             * A média deve ser impressa com dois dígitos após o ponto decimal.*/

            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine());

            soma = 0;
            cont = 0;
            while (idade >= 0)
            {
                cont++;
                soma += idade;
                idade = double.Parse(Console.ReadLine());
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
