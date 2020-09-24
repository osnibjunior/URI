using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
             * Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
             * mostrando essas informações.
             * 
             * Entrada
             * A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
             * Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
             * 
             * Saída
             * Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.*/

            int N = int.Parse(Console.ReadLine());
            int X = 0;
            int contIn = 0, contOut = 0;

            //É possível utilizar o while para resolver este problema, mas como ele faz parte do tópico recém saído de PARA
            //resolvi fazer ele com for. No caso do while, bastava iniciar uma variável zerada e ficar no laço enquanto cont < N, por exemplo.
            //ao final dos ifs, seria necessário somente incrementar o contador usando um cont++
            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    contIn++;
                } else
                {
                    contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
