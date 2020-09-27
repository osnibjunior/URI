using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
             * Escreva um algoritmo para ler o tipo de combustível abastecido, codificado da seguinte forma:
             * 1.Álcool
             * 2.Gasolina
             * 3.Diesel
             * 4.Fim
             * 
             * Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código
             * (até que seja válido). O programa será encerrado quando o código informado for o número 4.
             * 
             * Entrada
             * A entrada contém apenas valores inteiros e positivos.
             * 
             * Saída
             * Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram
             * cada tipo de combustível, conforme exemplo.*/

            int alcool = 0, gasolina = 0, diesel = 0, valor;

            valor = int.Parse(Console.ReadLine());

            while (valor != 4)
            {
                if (valor == 1)
                {
                    alcool++;
                } else if (valor == 2)
                {
                    gasolina++;
                } else if (valor == 3)
                {
                    diesel++;
                }
                valor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
