using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1142
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Escreva um programa que leia um valor inteiro N.
             * Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
             * 
             * Entrada
             * O arquivo de entrada contém um número inteiro positivo N.
             * 
             * Saída
             * Imprima a saída conforme o exemplo fornecido.*/

            int N = int.Parse(Console.ReadLine());
            int cont = 0;
            int linhas = N * 4;

            for (int i = 1; i <= linhas; i++)
            {
                cont++;
                if (cont % 4 != 0)
                {
                    Console.Write(cont + " ");
                } else
                {
                    Console.WriteLine("PUM");
                }
            }
        }
    }
}
