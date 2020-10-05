﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1150
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Faça um programa que leia dois inteiros: X e Z (devem ser lidos tantos valores para Z quantos necessários, até que seja digitado um valor maior do que X para ele).
             * Conte quantos números inteiros devem ser somados em sequência (considerando o X nesta soma) para que a soma ultrapasse a Z o mínimo possível. Escreva o valor final da contagem.
             * 
             * A entrada pode conter, por exemplo, os valores 21 21 15 30. Neste caso, é então assumido o valor 21 para X enquanto os valores 21 e 15 devem ser desconsiderados
             * pois são menores ou iguais a X. Como o valor 30 está dentro da especificação (maior do que X) ele será válido e então deve-se processar os cálculos para apresentar
             * na saída o valor 2, pois é a quantidade de valores somados para se produzir um valor maior do que 30 (21 + 22).
             * 
             * Entrada
             * A entrada contém somente valores inteiros, um por linha, podendo ser positivos ou negativos. O primeiro valor da entrada será o valor de X.
             * A próxima linha da entrada irá conter Z. Se Z não atender a especificação do problema, ele deverá ser lido novamente, tantas vezes quantas forem necessárias.
             * 
             * Saída
             * Imprima uma linha com um número inteiro que representa a quantidade de números inteiros que devem ser somadas, de acordo com a especificação acima.*/

            int X = int.Parse(Console.ReadLine());
            int cont = 1;
            int Y = 0;
            int soma = X;
            
            do
            {
                Y = int.Parse(Console.ReadLine());
            } while (Y <= X);
            
            while (Y >= soma)
            {
                X++;
                cont++;
                soma += X;
            }

            Console.WriteLine(cont);
        }
    }
}
